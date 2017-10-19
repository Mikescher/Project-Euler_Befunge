/* transpiled with BefunCompile v1.3.0 (c) 2017 */
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
    int64 t0;
    d();
    s=(int64*)calloc(q,sizeof(int64));
    gw(1,0,600);
    gw(2,0,150);
    gw(9,0,90000);
    gw(3,0,2);
    gw(4,0,1000);
    gw(3,1,0);
_1:
    gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+3,88);
    sa(gr(3,0)+gr(3,0));
    sa((gr(3,0)+gr(3,0))<gr(9,0)?1:0);
_2:
    if(sp()!=0)goto _22;else goto _3;
_3:
    sp();
_4:
    sa(gr(3,0)+1);
    sa(gr(3,0)+1);
    gw(3,0,gr(3,0)+1);
    sa(tm(sp(),gr(1,0)));

    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+3LL);

    {int64 v0=sp();t0=gr(sp(),v0);}
    t0-=32;
    if((t0)!=0)goto _6;else goto _4;
_6:
    if(gr(9,0)>gr(3,0))goto _1;else goto _7;
_7:
    gw(0,3,32);
    gw(1,3,32);
    gw(5,0,1-gr(4,0));
    gw(6,0,2);
_8:
    gw(7,0,0);
    sa((gr(5,0)*gr(7,0))+gr(6,0));
    sa(((gr(5,0)*gr(7,0))+gr(6,0))>1?1:0);
_9:
    if(sp()!=0)goto _10;else goto _21;
_10:
    sa(tm(sr(),gr(1,0)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+3LL);

    {int64 v0=sp();t0=gr(sp(),v0);}
    t0-=32;

    if((t0)!=0)goto _20;else goto _11;
_11:
    t0=gr(7,0);

    if(gr(7,0)>gr(3,1))goto _19;else goto _12;
_12:
    t0=gr(5,0)+2;
    gw(5,0,gr(5,0)+2);
    t0=t0>gr(4,0)?1:0;

    if((t0)!=0)goto _13;else goto _18;
_13:
    gw(5,0,1-gr(4,0));
_14:
    sa(gr(6,0)+1);
    sa(gr(6,0)+1);
    gw(6,0,gr(6,0)+1);
    sa(tm(sp(),gr(1,0)));

    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+3LL);

    {int64 v0=sp();t0=gr(sp(),v0);}
    t0-=32;
    if((t0)!=0)goto _16;else goto _14;
_16:
    if(gr(6,0)>gr(4,0))goto _17;else goto _18;
_17:
    printf("%lld ", gr(1,1)*gr(2,1));
    return 0;
_18:
    t0=0;
    goto _8;
_19:
    gw(3,1,t0);
    gw(1,1,gr(5,0));
    gw(2,1,gr(6,0));
    goto _12;
_20:
    sa((gr(7,0)+1)*(gr(7,0)+1));
    gw(7,0,gr(7,0)+1);
    sa(sp()+(gr(5,0)*gr(7,0))+gr(6,0));

    sa(sr()>1?1:0);
    goto _9;
_21:
    sp();
    goto _11;
_22:
    sa(sr());
    sa(32);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),gr(1,0)));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+3LL);

    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()+gr(3,0));

    sa(sr()<gr(9,0)?1:0);
    goto _2;
}
