/* compiled with BefunCompile v1.0.6 (c) 2015 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v{0} !%v{0} !$1>\"d\">1-:!#v_:03p013p\"~I\"+23p>23g\"d\"%1+23g\"d\"/g\"0\"-03g*13g+:55+%68 v{ }  F^     $#{ }  /_^#!p32:-1g32p31/+55p/\"d\"g"
           "32+1%\"d\"g32+*<{ }  L>\"~I\"+33p0>33g\"d\"%1+33g\"d\"/g\"0\"-+  33g:1-33p v{ }  ^@._^#!{ }  @<{ }  M";
int t=0;int z=0;
int64 g[606];
int d(){int s,w,i,j,h;h=z;for(;t<219;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<101&&y<6){return g[y*101+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<101&&y<6){g[y*101+x]=v;}}
int64 td(int64 a,int64 b){ return (b==0)?0:(a/b); }
int64 tm(int64 a,int64 b){ return (b==0)?0:(a%b); }
int64*s;int q=16384;int y=0;
int64 sp(){if(!y)return 0;return s[--y];}
void sa(int64 v){if(q-y<8)s=(int64*)realloc(s,(q*=2)*sizeof(int64));s[y++]=v;}
int64 sr(){if(!y)return 0;return s[y-1];}
int main(void)
{
    d();
    s=(int64*)calloc(q,sizeof(int64));
    sa(99LL);
_1:
    sa(sr());
    gw(0LL,3LL,sp());
    gw(1LL,3LL,0LL);
    gw(2LL,3LL,199LL);
_2:
    sa(((gr((tm(gr(2LL,3LL),100LL))+1LL,td(gr(2LL,3LL),100LL))-48LL)*gr(0LL,3LL))+gr(1LL,3LL));
    gw((tm(gr(2LL,3LL),100LL))+1LL,td(gr(2LL,3LL),100LL),(tm(((gr((tm(gr(2LL,3LL),100LL))+1LL,td(gr(2LL,3LL),100LL))-48LL)*gr(0LL,3LL))+gr(1LL,3LL),10LL))+48LL);
    sa(td(sp(),10L));
    gw(1LL,3LL,sp());
    sa(gr(2LL,3LL)-1LL);
    gw(2LL,3LL,gr(2LL,3LL)-1LL);
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _4;else goto _2;
_4:
    sa(sp()-1LL);
    sa(sr());
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _5;else goto _1;
_5:
    gw(3LL,3LL,199LL);
    sp();
    sa(gr((tm(gr(3LL,3LL),100LL))+1LL,td(gr(3LL,3LL),100LL))-48LL);
_6:
    sa(gr(3LL,3LL));
    gw(3LL,3LL,gr(3LL,3LL)-1LL);
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _7;else goto _8;
_7:
    printf("%lld", (int64)(sp()));
    return 0;
_8:
    sa(sp()+(gr((tm(gr(3LL,3LL),100LL))+1LL,td(gr(3LL,3LL),100LL))-48LL));
    goto _6;
}