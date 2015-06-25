/* Task Description */
/* 
	Create a function constructor for Person. Each Person must have:
	*	properties `firstname`, `lastname` and `age`
		*	firstname and lastname must always be strings between 3 and 20 characters, containing only Latin letters
		*	age must always be a number in the range [0 - 150],  inclusive
			*	the setter of age can receive a convertible-to-number value
		*	if any of the above is not met, throw Error 		
	*	property `fullname`
		*	the getter returns a string in the format 'FIRST_NAME LAST_NAME'
		*	the setter receives a string is the format 'FIRST_NAME LAST_NAME'
			*	it must parse it and set `firstname` and `lastname`
	*	method `introduce()` that returns a string in the format 'Hello! My name is FULL_NAME and I am AGE-years-old'
	*	all methods and properties must be attached to the prototype of the Person
	*	all methods and property setters must return this, if they are not supposed to return other value
		*	enables method-chaining
*/
function solve() {
    var Person = (function () {
        function Person(firstname, lastname, age) {
            if (!(this instanceof arguments.callee)) {
                return new Person(firstname, lastname, age);
            }
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
        }

        Object.defineProperty(Person.prototype, 'firstname', {
            get: function () {
                return this._firstname;
            },
            set: function (value) {
                validateName(value);

                this._firstname = value;
            }
        });

        Object.defineProperty(Person.prototype, 'lastname', {
            get: function () {
                return this._lastname;
            },
            set: function (value) {
                validateName(value);

                this._lastname = value;
            }
        });

        Object.defineProperty(Person.prototype, 'fullname', {
            get: function () {
                return this.firstname + ' ' + this.lastname;
            },
            set: function (value) {
                var fname = value.split(' ')[0];
                var lname = value.split(' ')[1];
                this._firstname = fname;
                this._lastname = lname;
            }
        });

        Object.defineProperty(Person.prototype, 'age', {
            get: function () {
                return this._age;
            },
            set: function (value) {
                validateAge(value);

                this._age = value;
            }
        });

        Person.prototype.introduce = function () {
            return 'Hello! My name is ' + this.fullname + ' and I am ' + this.age + '-years-old';
        }

        function validateAge(age) {
            if (age < 0 || age > 150) {
                throw new Error('Age must always be a number in the range (0, 150), inclusive');
            }
        }

        function validateName(name) {
            if (typeof name !== 'string') {
                throw new Error('Name must be a string');
            } else if (name.length < 3 || name.length > 20) {
                throw new Error('Name must be between the range [3-20] letters');
            }

            name.split('').forEach(function (ch) {
                if (!/[a-zA-Z]/.test(ch)) {
                    throw new Error('Name must contains only Latin letters');
                }
            });
        }

        return Person;
    }());
    return Person;
}

var person = solve();
var pesho = person('Joro', 'Yonchev', 22);
pesho.firstname = 'Georgi';
pesho.age = true;
console.log(pesho.fullname)
module.exports = solve;