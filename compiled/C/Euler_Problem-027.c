/* compiled with BefunCompile v1.0.6 (c) 2015 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v     // Project Euler - Problem 12{ } 2W{#})|C{ } &>>\"d\"6*:10p3\"2\"*:20p*90p230p5558***40p031pv{ }  5>\" \":03p13pv{ } %Rv{ }  H<{"
           " }  4_^#`g03g09 <{ } %S>\"X\"30g:10g%\\10g/3+p30g>30g+:90g\\`{ }  '#v_$>30g1+:30p:10g%\\10g/3+g\" \"- |{ } %j^p+3/g01\\%g01:\\\" \":<  ^{ }"
           "  ;<{ } %Sv{ }  i<{ } %gv{ }  1># v#{ }  (p07:+1g07<{ }  )>31p50g11p60g21pv{ }  =v{ }  <<   @.*g12g11<{ } $\\>040g-1+50p260p>0:70"
           "p>:*50g70g*60g++:1`|  >:10g%\\10g/3+g\" \"-#^_70g:31g`|{ }  />50g2+:50p40g`!#v_ >040g-1+50p>60g1+:60p:10g%\\10g/3+g\" \"-!#^_60g40g`!#"
           "v_^{ } $k^{ }  7># $0{ }  2^#{ }  '># $#{ }  +^#{ }  .<#{ }  T<{ } $^";
int t=0;int z=0;
int64 g[97200];
int d(){int s,w,i,j,h;h=z;for(;t<581;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<600&&y<162){return g[y*600+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<600&&y<162){g[y*600+x]=v;}}
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
    gw(1LL,0LL,600LL);
    gw(2LL,0LL,150LL);
    gw(9LL,0LL,90000LL);
    gw(3LL,0LL,2LL);
    gw(4LL,0LL,1000LL);
    gw(3LL,1LL,0LL);
_1:
    gw(tm(gr(3LL,0LL),gr(1LL,0LL)),(td(gr(3LL,0LL),gr(1LL,0LL)))+3LL,88LL);
    sa(gr(3LL,0LL)+gr(3LL,0LL));
    sa((gr(3L,0L)+gr(3L,0L))<gr(9L,0L)?1:0);
_2:
    if(sp()!=0)goto _22;else goto _3;
_3:
    sp();
_4:
    sa(gr(3LL,0LL)+1LL);
    gw(3LL,0LL,gr(3LL,0LL)+1LL);
    sa(tm(sr(),gr(1LL,0LL)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1L,0L)));
    sa(sp()+3LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()-32LL);
    if(sp()!=0)goto _6;else goto _4;
_6:
    if(gr(9L,0L)>gr(3L,0L))goto _1;else goto _7;
_7:
    gw(0LL,3LL,32LL);
    gw(1LL,3LL,32LL);
    gw(5LL,0LL,1LL-gr(4LL,0LL));
    gw(6LL,0LL,2LL);
_8:
    gw(7LL,0LL,0LL);
    sa((gr(5LL,0LL)*gr(7LL,0LL))+gr(6LL,0LL));
    sa(((gr(5L,0L)*gr(7L,0L))+gr(6L,0L))>1L?1:0);
_9:
    if(sp()!=0)goto _10;else goto _21;
_10:
    sa(tm(sr(),gr(1LL,0LL)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1L,0L)));
    sa(sp()+3LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()-32LL);
    if(sp()!=0)goto _20;else goto _11;
_11:
    sa(gr(7LL,0LL));
    if(gr(7L,0L)>gr(3L,1L))goto _19;else goto _12;
_12:
    sp();
_13:
    sa(gr(5LL,0LL)+2LL);
    gw(5LL,0LL,gr(5LL,0LL)+2LL);
    sa((sp()>gr(4L,0L))?1:0);
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _8;else goto _14;
_14:
    gw(5LL,0LL,1LL-gr(4LL,0LL));
_15:
    sa(gr(6LL,0LL)+1LL);
    gw(6LL,0LL,gr(6LL,0LL)+1LL);
    sa(tm(sr(),gr(1LL,0LL)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1L,0L)));
    sa(sp()+3LL);
    {int64 v0=sp();sa(gr(sp(),v0));}
    sa(sp()-32LL);
    sa((sp()!=0)?0:1);
    if(sp()!=0)goto _15;else goto _17;
_17:
    if(gr(6L,0L)<=gr(4L,0L))goto _8;else goto _18;
_18:
    printf("%lld", (int64)(gr(1LL,1LL)*gr(2LL,1LL)));
    return 0;
_19:
    gw(3LL,1LL,sp());
    gw(1LL,1LL,gr(5LL,0LL));
    gw(2LL,1LL,gr(6LL,0LL));
    goto _13;
_20:
    sa(gr(7LL,0LL)+1LL);
    gw(7LL,0LL,gr(7LL,0LL)+1LL);
    sa(sr());
    sa(sp()*sp());
    sa(sp()+(gr(5LL,0LL)*gr(7LL,0LL))+gr(6LL,0LL));
    sa(sr()>1L?1:0);
    goto _9;
_21:
    sp();
    goto _11;
_22:
    sa(sr());
    sa(32LL);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),gr(1LL,0LL)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1L,0L)));
    sa(sp()+3LL);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()+gr(3LL,0LL));
    sa(sr()<gr(9L,0L)?1:0);
    goto _2;
}