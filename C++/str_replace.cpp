#include iostream
#include string
using namespace std;

void string_replace( stdstring &strBig, const stdstring &strsrc, const stdstring &strdst);

int main()
{
    string a;
    cout  log and lat  endl;
    cin  a;
    cout  a  a  endl;
    string_replace(a, (, [);
    string_replace(a, ), ]);

    cout  a  a  endl;
    system(pause);

    return 0;
    
}

void string_replace( stdstring &strBig, const stdstring &strsrc, const stdstring &strdst)
{
    stdstringsize_type pos = 0;
    stdstringsize_type srclen = strsrc.size();
    stdstringsize_type dstlen = strdst.size();

    while( (pos=strBig.find(strsrc, pos)) != stdstringnpos )
    {
        strBig.replace( pos, srclen, strdst );
        pos += dstlen;
    }
} 