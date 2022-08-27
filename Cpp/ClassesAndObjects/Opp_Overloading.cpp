#include <iostream>

class Rational {
    int _n = 0;
    int _d = 1;
    
    public:
        Rational(int numerator = 0, int denominator = 1) : _n(numerator), _d(denominator) {
            
        };
        Rational(const Rational & rhs) : _n(rhs._n), _d(rhs._d) {

        };
        
        ~Rational();

        int numerator() const {
            return _n;
        }

        int denominator() const {
            return _d;
        }

        Rational & operator = (const Rational &);
        Rational operator + (const Rational &) const;
        Rational operator - (const Rational &) const;
        Rational operator * (const Rational &) const;
        Rational operator / (const Rational &) const;
};

Rational & Rational::operator = (const Rational & rhs) { // & returns a reference to the object
    if(this != &rhs) { // compares the object to the object on the right hand side, if not equal does the assignment
        _n = rhs.numerator();
        _d = rhs.denominator();
    }
    return *this;   // that reference is returned by *this pointer
}

Rational Rational::operator + (const Rational & rhs) const {
    return Rational ((_n * rhs._d) + (_d * rhs._n), _d * rhs._d);
}

Rational Rational::operator - (const Rational & rhs) const {
    return Rational ((_n * rhs._d) - (_d * rhs._n), _d * rhs._d);
}

Rational Rational::operator * (const Rational & rhs) const {
    return Rational ((_n * rhs._n), _d * rhs._d);
}    

Rational Rational::operator / (const Rational & rhs) const {
    return Rational ((_n * rhs._d), _d * rhs._n);
}

Rational::~Rational () {
    _n = 0;
    _d = 1;
}

// for std::cout
std::ostream & operator << (std::ostream & o, const Rational & r) {
    if (r.denominator() == 1)
        return o << r.numerator();
    else
        return o << r.numerator() << '/' << r.denominator();
}

int main () {
    using std::cout;
    using std::endl;

    Rational a = 7;
    cout << "a is: " << a << endl;

    Rational b(5, 3);
    cout << "b is: " << b << endl;

    Rational c = b; // copy constructor
    cout << "c is: " << c << endl;

    Rational d; // default costructor
    cout << "d is: " << d << endl;

    Rational & e = d; // reference
    d = e; // self assignment
    cout << "e is: " << e << endl;

    cout << a << " + " << b << " = " << a + b << endl;
    cout << a << " - " << b << " = " << a - b << endl;
    cout << a << " * " << b << " = " << a * b << endl;
    cout << a << " / " << b << " = " << a / b << endl;

    return 0;
}