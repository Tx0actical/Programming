#include <iostream>
#include <string>

namespace User_Defined {
    const std::string prefix = "User_Defined::string";

    class string {
        const std::string _s = "";
        string();
        public:
            string (const string & s) : _s(prefix + s) {

            }
            const char * c_str() const {
                return _s.c_str();
            }
            operator std::string & () {
                return _s;
            }
            operator const char * () const {
                return _s.c_str();
            }
    };
};

int main() {
    const std::string s1("This is a string");
    std::puts(s1.c_str());

    const User_Defined::string s2(s1);
    std::puts(s2);

    return 0;
}