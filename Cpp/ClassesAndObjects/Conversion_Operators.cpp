#include <iostream>
#include <string>

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
        operator std::string() const;
};

Rational & Rational::operator = (const Rational & rhs) { // & returns a reference to the object
    if(this != &rhs) { // compares the object to the object on the right hand side, if not equal does the assignment
        _n = rhs.numerator();
        _d = rhs.denominator();
    }
    return *this;   // that reference is returned by *this pointer
}

Rational operator + (const Rational & lhs, const Rational & rhs) {
    return Rational ((lhs.numerator() * rhs.denominator()) + (rhs.denominator() * rhs.numerator()), lhs.denominator() * rhs.denominator());
}

Rational operator - (const Rational & lhs, const Rational & rhs) {
    return Rational ((lhs.numerator() * rhs.denominator()) - (rhs.denominator() * rhs.numerator()), lhs.denominator() * rhs.denominator());
}

Rational operator * (const Rational & lhs, const Rational & rhs) {
    return Rational ((lhs.numerator() * rhs.numerator()), (rhs.denominator() * rhs.denominator()));
}    

Rational operator / (const Rational & lhs, const Rational & rhs) {
    return Rational ((lhs.numerator() * rhs.denominator()), (rhs.denominator() * rhs.numerator()));
}

Rational::operator std::string() const {
    if (_d == 1)
        return std::to_string(_n);
    else
        return std::to_string(_n) + "/" + std::to_string(_d);
}

Rational::~Rational () {
    _n = 0;
    _d = 1;
}

// for std::cout
std::ostream & operator << (std::ostream & o, const Rational & r) {
    return o << std::string(r);
}

int main () {
    using std::cout;
    using std::endl;
    using std::string;

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

    string s = "Rational value is: ";
    s += b;
    cout << s << endl;

    return 0;
}