#include <iostream>
#include <string>
using namespace std;

void string_replace( std::string &strBig, const std::string &strsrc, const std::string &strdst);

int main()
{
    string a;
    cout << "log and lat:" << endl;
    cin >> a;
    cout << "a:" << a << endl;
    string_replace(a, "(", "[");
    string_replace(a, ")", "]");

    cout << "a:" << a << endl;

    system("pause");

    return 0;
    
}

void string_replace( std::string &strBig, const std::string &strsrc, const std::string &strdst)
{
    std::string::size_type pos = 0;
    std::string::size_type srclen = strsrc.size();
    std::string::size_type dstlen = strdst.size();

    // 查找字符串，如果没有到字符串的结尾，则一直循环
    while( (pos=strBig.find(strsrc, pos)) != std::string::npos )
    {
        strBig.replace( pos, srclen, strdst );
        pos += dstlen;
    }
} 