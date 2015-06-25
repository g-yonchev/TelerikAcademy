/* Task Description */
/* 
* Create a module for a Telerik Academy course
  * The course has a title and presentations
    * Each presentation also has a title
    * There is a homework for each presentation
  * There is a set of students listed for the course
    * Each student has firstname, lastname and an ID
      * IDs must be unique integer numbers which are at least 1
  * Each student can submit a homework for each presentation in the course
  * Create method init
    * Accepts a string - course title
    * Accepts an array of strings - presentation titles
    * Throws if there is an invalid title
      * Titles do not start or end with spaces
      * Titles do not have consecutive spaces
      * Titles have at least one character
    * Throws if there are no presentations
  * Create method addStudent which lists a student for the course
    * Accepts a string in the format 'Firstname Lastname'
    * Throws if any of the names are not valid
      * Names start with an upper case letter
      * All other symbols in the name (if any) are lowercase letters
    * Generates a unique student ID and returns it
  * Create method getAllStudents that returns an array of students in the format:
    * {firstname: 'string', lastname: 'string', id: StudentID}
  * Create method submitHomework
    * Accepts studentID and homeworkID
      * homeworkID 1 is for the first presentation
      * homeworkID 2 is for the second one
      * ...
    * Throws if any of the IDs are invalid
  * Create method pushExamResults
    * Accepts an array of items in the format {StudentID: ..., Score: ...}
      * StudentIDs which are not listed get 0 points
    * Throw if there is an invalid StudentID
    * Throw if same StudentID is given more than once ( he tried to cheat (: )
    * Throw if Score is not a number
  * Create method getTopStudents which returns an array of the top 10 performing students
    * Array must be sorted from best to worst
    * If there are less than 10, return them all
    * The final score that is used to calculate the top performing students is done as follows:
      * 75% of the exam result
      * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
*/

function solve() {
    'use strict';
    var Course = {
        init: function (title, presentations) {
            var self = this,
                presentation,
                lastHomeworkId = 0;

            if (title.length < 1) {
                throw new Error('Empty course title');
            }
            if (/^\s|\s$|\s{2,}/.test(title)) {
                throw new Error('Invalid course title');
            }
            if (presentations === undefined || presentations.length === 0) {
                throw new Error('There should be at least one presentation');
            }

            presentations.forEach(function (title) {
                if (/^\s|\s$|\s{2,}/.test(title) || title.length < 1) {
                    throw new Error('Invalid presentation title');
                }
            });

            self.title = title;

            self.students = [];
            self.presentations = [];

            presentations.forEach(function (title) {

                presentation = {
                    title: title,
                    id: ++lastHomeworkId
                };
                self.presentations.push(presentation);
            });

            return this;
        },
        addStudent: function (name) {
            var student,
                firstName,
                lastName,
                self;

            if (typeof name !== 'string') {
                throw new Error();
            }
            if (!/^[A-Z][a-z]*\s([A-Z]{1}[a-z]*)$/.test(name)) {
                throw new Error();
            }

            self = this;
            firstName = name.split(' ')[0];
            lastName = name.split(' ')[1];

            student = {
                firstname: firstName,
                lastname: lastName,
                score: 0,
                visitExam: false,
                totalScore: 0,
                id: self.students.length + 1
            };

            this.students.push(student);

            return student.id;
        },
        getAllStudents: function () {
            return this.students.slice(0);
        },
        submitHomework: function (studentID, homeworkID) {
            function validateId(id, objects, type) {
                var hasValidId = false;
                objects.forEach(function (obj) {
                    if (obj.id === id) {
                        hasValidId = true;
                        return;
                    }
                });

                if (!hasValidId) {
                    throw new Error('Invalid ' + type + ' id');
                }
            }

            validateId(homeworkID, this.presentations, 'homework');
            validateId(studentID, this.students, 'student');

            this.students.forEach(function (student) {
                if (student.id === studentID) {
                    if (student.homeworks === undefined) {
                        student.homeworks = 1;
                    } else {
                        student.homeworks += 1;
                    }
                }
            });

            return this;
        },
        pushExamResults: function (results) {
            var self = this;
            results.forEach(function (studentWithScore) {
                var studentId = studentWithScore.StudentID,
                    score = studentWithScore.Score;

                if (isNaN(score) || score === '') {
                    throw new Error('Invalid score');
                }

                if (!self.students[studentId - 1]) {
                    throw new Error('Invalid id');
                }

                if (self.students[studentId - 1].visitExam === true) {
                    throw new Error('Cheater :)');
                }

                self.students[studentId - 1].visitExam = true;
                self.students[studentId - 1].score = score;
            });

            return self;
        },
        getTopStudents: function () {
            var self = this,
                topStudents;
            self.students.forEach(function (student) {
                student.totalScore = (0.75 * student.score) + (25 * (student.homeworks / self.presentations.length));
            });

            self.students.sort(function (firstStudent, secondStudent) {
                return firstStudent.totalScore - secondStudent.totalScore;
            });

            topStudents = self.students.slice(0, 10);

            return topStudents;
        }
    };

    return Course;
}

module.exports = solve;
