/* transpiled with BefunCompile v1.3.0 (c) 2017 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v{$$  ### {-}  ` ###    }  \"{$   ### {-}  ` ###    }  \"$   {### {-}  ` ###{ }  (}  '### {-}  ` ###{ }  .v_v#!{ }  *_v#{ }  7<1  "
           "    g02$$<{ }  0#####    1 v  p02g01_v#! #  g02$_v#!:p\\+9%*88g02 <0{ }  ;> # 6 # 10p   288** 20p>20g1-20p10g>1-:0\\2*20g88*/+^^ $"
           "<0p03+1g03 p+*2g02/*88g<   #####    0 >20g1-20p030p0>1+::::*\\-2/20g1+*+:\";}\"8*\\`#^_:\"ec\"*`#^_30g88*%9+30^{ }  ,>g>1-:0\\5\\p:0\\6\\p"
           ":0\\7\\p:#v_$  01-60p011p v{ }  ;v<{ }  )$_^#!:{ }  3<0{ }  .{<     }  \"  <$$<{ }  *>611gg1+611gp611gg12p511gg13p12g10g-!#v_13g\"_ "
           "\"+`#v_712gg#^_13g88* %9+13g88*/12v^<pg115+1gg115pg116-10{ }  0<v88g-1g115+9%*88g-1g115g11_^#g41p41g+*2g<^<pgg11670p11-1g11{ }  5"
           "*#{ }  ($<v05+9%*8{ }  (8g05%\"d\"g41<{ }  H>/611g1-g2*+g\"d\"%14g\"d\"/-*#^_10g1-11g`!| ^<pg1150pg116-10p11+1g11pg2171{ }  P< >2*+g:."
           "+55+,21g1+:21p10g-#v_\" =  \",,,,.@{ }  +>88*/60g2*+g\"d\"/-#^_v{ }  (^gg126/*88gg125+9%*88gg125<0p120{ }  G<{ }  (";
int t=0;int z=0;
int64 g[2000];
int d(){int s,w,i,j,h;h=z;for(;t<879;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<80&&y<25){return g[y*80+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<80&&y<25){g[y*80+x]=v;}}
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
    gw(1,0,6);
    gw(2,0,128);
_1:
    gw(2,0,gr(2,0)-1);
    sa(gr(1,0)-1);
    sa(gr(1,0)-1);
    gw((gr(2,0)%64)+9,((gr(1,0)-1)*2)+(gr(2,0)/64),0);
_2:
    if(sp()!=0)goto _34;else goto _3;
_3:
    sp();

    if((gr(2,0))!=0)goto _1;else goto _4;
_4:
    gw(2,0,gr(1,0));
_5:
    gw(2,0,gr(2,0)-1);
    gw(3,0,0);
    sa(1);
    sa(1+(0*(gr(2,0)+1)));
    sa((1+(0*(gr(2,0)+1)))<1000?1:0);
_6:
    if(sp()!=0)goto _7;else goto _8;
_7:
    sp();
    sa(sp()+1LL);

    sa(sr());
    sa(sr());
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    t0=sp();
    sa(t0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();sa(sp()-v0);}

    t1=sp();
    t1/=2;
    t1*=gr(2,0)+1;
    sa(sp()+t1);

    sa(sr()<1000?1:0);
    goto _6;
_8:
    if(sr()>9999)goto _9;else goto _33;
_9:
    sp();
    sp();

    if((gr(2,0))!=0)goto _5;else goto _10;
_10:
    sa(gr(1,0)-1);
    sa(0);
    sa(6);
    sa(gr(1,0)-1);
    gw(5,gr(1,0)-1,0);
_11:
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(7);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());

    if(sp()!=0)goto _12;else goto _32;
_12:
    sa(sr());
    sa((sp()!=0)?0:1);
_13:
    if(sp()!=0)goto _14;else goto _31;
_14:
    sp();
_15:
    gw(6,gr(1,1),gr(6,gr(1,1))+1);
    gw(1,2,gr(6,gr(1,1)));
    gw(1,3,gr(5,gr(1,1)));

    if((gr(1,2)-gr(1,0))!=0)goto _17;else goto _16;
_16:
    gw(6,gr(1,1),-1);
    gw(5,gr(1,1),gr(5,gr(1,1))+1);
    goto _15;
_17:
    if(gr(1,3)>127)goto _18;else goto _19;
_18:
    gw(1,1,gr(1,1)-1);
    gw(7,gr(6,gr(1,1)),0);
    t0=9;
    goto _15;
_19:
    if((gr(7,gr(1,2)))!=0)goto _21;else goto _20;
_20:
    gw(1,4,gr((gr(1,3)%64)+9,(gr(1,3)/64)+(gr(1,2)*2)));

    if((gr(1,4))!=0)goto _22;else goto _21;
_21:
    sa(0);
    sa(1);
    goto _13;
_22:
    if((gr(1,1)*((gr((gr(5,gr(1,1)-1)%64)+9,(gr(5,gr(1,1)-1)/64)+(gr(6,gr(1,1)-1)*2))%100)-(gr(1,4)/100)))!=0)goto _21;else goto _23;
_23:
    if((gr(1,0)-1)>gr(1,1))goto _24;else goto _25;
_24:
    gw(7,gr(1,2),1);
    gw(1,1,gr(1,1)+1);
    gw(6,gr(1,1),-1);
    gw(5,gr(1,1),0);
    goto _15;
_25:
    if(((gr(1,4)%100)-(gr((gr(5,0)%64)+9,(gr(5,0)/64)+(gr(6,0)*2))/100))!=0)goto _30;else goto _26;
_26:
    gw(2,1,0);
    printf("%lld ", gr((gr(5,gr(2,1))%64)+9,(gr(5,gr(2,1))/64)+(gr(6,gr(2,1))*2)));
    printf("\n");
    t0=gr((gr(5,gr(2,1))%64)+9,(gr(5,gr(2,1))/64)+(gr(6,gr(2,1))*2));
_27:
    t1=gr(2,1)+1;
    gw(2,1,gr(2,1)+1);
    t1-=gr(1,0);

    if((t1)!=0)goto _29;else goto _28;
_28:
    printf("  = ");
    printf("%lld ", t0);
    return 0;
_29:
    printf("%lld ", gr((gr(5,gr(2,1))%64)+9,(gr(5,gr(2,1))/64)+(gr(6,gr(2,1))*2)));
    printf("\n");
    t0+=gr((gr(5,gr(2,1))%64)+9,(gr(5,gr(2,1))/64)+(gr(6,gr(2,1))*2));
    goto _27;
_30:
    t0=0;
    t1=4;
    goto _21;
_31:
    sa(sp()-1LL);

    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(5);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(6);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    goto _11;
_32:
    gw(6,0,-1);
    gw(1,1,0);
    sp();
    goto _21;
_33:
    gw((gr(3,0)%64)+9,(gr(3,0)/64)+(gr(2,0)*2),sp());
    gw(3,0,gr(3,0)+1);
    sa(0);
    goto _7;
_34:
    sa(sp()-1LL);

    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()*2LL);

    sa(sp()+(gr(2,0)/64));

    sa((gr(2,0)%64)+9);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    goto _2;
}
