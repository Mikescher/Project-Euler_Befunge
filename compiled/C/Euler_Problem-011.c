/* compiled with BefunCompile v1.0.6 (c) 2015 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "{v{ }  -}  \"{ }  @<{ }  z>\"4\"2/:*1-00p > 000g: \"4\"2/ %\"?\"+\\ \"4\"2/ /1+ p  00g:1-00p  #^_v{{+}  :{ } !>}  \"{+}  :{ }  _08 02 22 97"
           " 38 15 00 40 00 75 04 05 07 78 52 12 50 77 91 08 | +++{#}  4+++{ }  _49 49 99 40 17 81 18 57 60 87 17 40 98 43 69 48 04 56 62 00"
           " | +++{#}  4+++{ }  _81 49 31 73 55 79 14 29 93 71 40 67 53 88 30 03 49 13 36 65 | +++{#}  4+++{ }  _52 70 95 23 04 60 11 42 69 "
           "24 68 56 01 32 56 71 37 02 36 91 | +++{#}  4+++{ }  _22 31 16 71 51 67 63 89 41 92 36 54 22 40 40 28 66 33 13 80 | +++{#}  4+++{"
           " }  _24 47 32 60 99 03 45 02 44 75 33 53 78 36 84 20 35 17 12 50 | +++{#}  4+++{ }  _32 98 81 28 64 23 67 10 26 38 40 67 59 54 7"
           "0 66 18 38 64 70 | +++{#}  4+++{ }  _67 26 20 68 02 62 12 20 95 63 94 39 63 08 40 91 66 49 94 21 | +++{#}  4+++{ }  _24 55 58 05"
           " 66 73 99 26 97 17 78 78 96 83 14 88 34 89 63 72 | +++{#}  4+++{ }  _21 36 23 09 75 00 76 44 20 45 35 14 00 61 33 97 34 31 33 95"
           " | +++{#}  4+++{ }  _78 17 53 28 22 75 31 67 15 94 03 80 04 62 16 14 09 53 56 92 | +++{#}  4+++{ }  _16 39 05 42 96 35 31 47 55 "
           "58 88 24 00 17 54 24 36 29 85 57 | +++{#}  4+++{ }  _86 56 00 48 35 71 89 07 05 44 44 37 44 60 21 58 51 54 17 58 | +++{#}  4+++{"
           " }  _19 80 81 68 05 94 47 69 28 73 92 13 86 52 17 77 04 89 55 40 | +++{#}  4+++{ }  _04 52 08 83 97 35 99 16 07 97 57 32 16 26 2"
           "6 79 33 27 98 66 | +++{#}  4+++{ }  _88 36 68 87 57 62 20 72 03 46 33 67 46 55 12 32 63 93 53 69 | +++{#}  4+++{ }  _04 42 16 73"
           " 38 25 39 11 24 94 72 18 08 46 29 32 40 62 76 36 | +++{#}  4+++{ }  _20 69 36 41 72 30 23 88 34 62 99 69 82 67 59 85 74 04 36 16"
           " | +++{#}  4+++{ }  _20 73 35 29 78 31 90 01 74 31 49 71 48 86 81 16 23 57 05 54 | +++{#}  4+++{ }  _01 70 54 71 83 51 54 69 16 "
           "92 33 48 61 43 52 01 89 19 67 48 | +++{#}  4+++{ }  ^vp00-1*:*45    p1++1550p0++1551p1+55-10p0+551p19-10p090   p010<{+}  :{ }  5"
           ">10pv{ }  D>00g:54*%3*1+\\54*/4+g\"0\"-52**00g:54*%3*2+\\54*/4+g\"0\"-+00g:54*%v{+}  :{ }  7>$>     v{ }  >|{ }  Hp00-1:g00p+4/*45\\+\"B"
           "\"<{+}  :{ }  5^_^#`g01:<     v{ }  1<{ }  '>54*:*1-00p>220p>20g9+:0g30p1g40p00g:54*%50p54*/60p50g\"B\"+60g4+g50g30g+50p60g40g+60p>"
           "50g\"B\"+60g4+g50g30g+50p60g40g+60pv >20g:1-20p#v_00g:1-00p#^_10g. @{ }  +^   _^#{ }  a<vp06+g04g06p05+g03g05g+4g06+\"B\"g05<^ <  v "
           "    0<{ } !(>50g\"B\"+60g4+g50g30g+50p60g40g+60p***^{ } !1^{ }  H<<{ }  9";
int t=0;int z=0;
int64 g[4681];
int d(){int s,w,i,j,h;h=z;for(;t<2247;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<151&&y<31){return g[y*151+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<151&&y<31){g[y*151+x]=v;}}
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
    gw(0LL,0LL,675LL);
_1:
    gw((tm(gr(0LL,0LL),26LL))+63LL,(td(gr(0LL,0LL),26LL))+1LL,0LL);
    sa(gr(0LL,0LL));
    gw(0LL,0LL,gr(0LL,0LL)-1LL);
    if(sp()!=0)goto _1;else goto _3;
_3:
    gw(1LL,0LL,0LL);
    gw(9LL,0LL,0LL);
    gw(9LL,1LL,-1LL);
    gw(10LL,0LL,1LL);
    gw(10LL,1LL,-1LL);
    gw(11LL,0LL,1LL);
    gw(11LL,1LL,0LL);
    gw(0LL,0LL,399LL);
_4:
    gw((tm(gr(0LL,0LL),20LL))+66LL,(td(gr(0LL,0LL),20LL))+4LL,((gr(((tm(gr(0LL,0LL),20LL))*3LL)+1LL,(td(gr(0LL,0LL),20LL))+4LL)-48LL)*10LL)+(gr(((tm(gr(0LL,0LL),20LL))*3LL)+2LL,(td(gr(0LL,0LL),20LL))+4LL)-48LL));
    sa(gr(0LL,0LL));
    gw(0LL,0LL,gr(0LL,0LL)-1LL);
    if(sp()!=0)goto _4;else goto _6;
_6:
    gw(0LL,0LL,399LL);
_7:
    gw(2LL,0LL,2LL);
_8:
    sa(gr(2LL,0LL)+9LL);
    gw(3LL,0LL,gr(gr(2LL,0LL)+9LL,0LL));
    sa(1LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    gw(4LL,0LL,sp());
    sa(gr(0LL,0LL));
    gw(5LL,0LL,tm(gr(0LL,0LL),20LL));
    sa(td(sp(),20L));
    gw(6LL,0LL,sp());
    sa(gr(gr(5LL,0LL)+66LL,gr(6LL,0LL)+4LL));
    gw(5LL,0LL,gr(5LL,0LL)+gr(3LL,0LL));
    gw(6LL,0LL,gr(6LL,0LL)+gr(4LL,0LL));
    sa(gr(gr(5LL,0LL)+66LL,gr(6LL,0LL)+4LL));
    gw(5LL,0LL,gr(5LL,0LL)+gr(3LL,0LL));
    gw(6LL,0LL,gr(6LL,0LL)+gr(4LL,0LL));
    sa(gr(gr(5LL,0LL)+66LL,gr(6LL,0LL)+4LL));
    gw(5LL,0LL,gr(5LL,0LL)+gr(3LL,0LL));
    gw(6LL,0LL,gr(6LL,0LL)+gr(4LL,0LL));
    sa(gr(gr(5LL,0LL)+66LL,gr(6LL,0LL)+4LL));
    gw(5LL,0LL,gr(5LL,0LL)+gr(3LL,0LL));
    gw(6LL,0LL,gr(6LL,0LL)+gr(4LL,0LL));
    sa(sp()*sp());
    sa(sp()*sp());
    sa(sp()*sp());
    if(sr()>gr(1L,0L))goto _13;else goto _9;
_9:
    sp();
_10:
    sa(gr(2LL,0LL));
    gw(2LL,0LL,gr(2LL,0LL)-1LL);
    if(sp()!=0)goto _8;else goto _11;
_11:
    sa(gr(0LL,0LL));
    gw(0LL,0LL,gr(0LL,0LL)-1LL);
    if(sp()!=0)goto _7;else goto _12;
_12:
    printf("%lld", (int64)(gr(1LL,0LL)));
    return 0;
_13:
    gw(1LL,0LL,sp());
    goto _10;
}