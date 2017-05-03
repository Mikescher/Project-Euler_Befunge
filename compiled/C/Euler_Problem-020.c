/* transpiled with BefunCompile v1.1.0 (c) 2015 */
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
    int64 t0,t1;
    d();
    s=(int64*)calloc(q,sizeof(int64));
    sa(99);
_1:
    sa(sr());
    gw(0,3,sp());
    gw(1,3,0);
    gw(2,3,199);
_2:
    t0=((gr((tm(gr(2,3),100))+1,td(gr(2,3),100))-48)*gr(0,3))+gr(1,3);
    gw((tm(gr(2,3),100))+1,td(gr(2,3),100),(tm(((gr((tm(gr(2,3),100))+1,td(gr(2,3),100))-48)*gr(0,3))+gr(1,3),10))+48);
    t0/=10;
    gw(1,3,t0);
    t0=gr(2,3)-1;
    gw(2,3,gr(2,3)-1);
    t0=(t0!=0)?0:1;
    if((t0)!=0)goto _4;else goto _2;
_4:
    sa(sp()-1LL);

    sa(sr());
    sa((sp()!=0)?0:1);

    if(sp()!=0)goto _5;else goto _1;
_5:
    gw(3,3,199);
    sp();
    t0=gr((tm(gr(3,3),100))+1,td(gr(3,3),100))-48;
_6:
    t1=gr(3,3);
    gw(3,3,gr(3,3)-1);
    t1=(t1!=0)?0:1;

    if((t1)!=0)goto _7;else goto _8;
_7:
    printf("%lld", t0);
    return 0;
_8:
    t0+=gr((tm(gr(3,3),100))+1,td(gr(3,3),100))-48;
    goto _6;
}
