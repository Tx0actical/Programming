#include <iostream>
#include <cstdio>
#include <string>

using std::string;
using std::cout;

const string unk = "Unknown";
const string clone_prefix = "Clone-";

class Animal {
    
    string _type    = "";
    string _name    = "";
    string _sound   = "";

public:
    Animal();
    Animal (const string &type, const string &name, const string &sound);
    Animal (const Animal &); // copy constructor
    Animal & operator = (const Animal &); // copy operator
    ~Animal(); 

    void print() const;  
};

Animal::Animal() : _type(unk), _name(unk), _sound(unk) {
    puts ("Default constructor");
}

Animal::Animal(const string &type, const string &name, const string &sound) : _type(type), _name(name), _sound(sound) {
    puts("Parameterized constructor");
}

Animal::Animal(const Animal & rhs) {
    puts("Copy constructor");
    _name   = clone_prefix + rhs._name;
    _type   = rhs._type;
    _sound  = rhs._sound;
}

Animal::~Animal() {
    puts("Destructor called");
}

void Animal::print() const {
    cout << _name.c_str() << " the " << _type.c_str() << " says " << _sound.c_str();
}

Animal & Animal::operator = (const Animal & rhs) {
    cout << "Copy operator";
    if(this != &rhs) {
        _name   = clone_prefix + rhs._name;
        _type   = rhs._type;
        _sound  = rhs._sound;
    }
    return *this;
}

int main() {

    Animal A;
    A.print();

    const Animal b("cat", "fluffy", "meow");
    b.print();

    const Animal c = b;
    c.print();

    A = c;
    A.print();

    return 0;
}