/* transpiled with BefunCompile v1.3.0 (c) 2017 */
#include <stdio.h>
#include <stdlib.h>
#define int64 long long
char* _g = "v X X XX X{ }  d{#}  \\{ }  f@{ }  '{#}  \\ .{ }  dg{ }  '{#}  \\ 0{ }  d^9$># #<{ }  ){v{ }  -}  \"  <   v    <{ }  /$ v_^#-\"d\"\\+1:"
           "<{ }  '<>$\"<\">1-::9+5g\\9+1p:#^_$0>:::9+3g55+%55+*v>090p2>:20p\"d\">::*20g-#v_$^|!:-1p5+8\\-g07g06p04{ }  *#{ }  )<\\    #  v\"<\":$_^#"
           "   !:-1<   >::9+1g40g-60p:9+3g20g45***70p0>70g60g`!|5    ^ <>1-:0\\9+1p:0\\v      ^{ }  )\";;\"p04* :g02p5\"D\"0p<#+{ }  (65{ }  '|:p5"
           "+9\\0:p3+9< >9+1g-!#v_::9+5g\\9+1g`!#v_$20g1-20^ 1{ }  (0+{ }  '>$\"D\"1p\"d\"020p>20g:*40p \"<\">1-::9+3g20g 45***40gv  ^p06+\"d\"g<+    "
           "  ^ _>{ }  )#v^#-\"<\":+1<   |:p5+9\\%\"d\"p 04/\"d\":+<v3+9\\+/+55g3<{ }  3v_v^\\g5+9::<0 $<{ }  0v:+1p<#{ }  4^p02+1g02$>#<#{ }  '^#{ }"
           "  .<    > \";;\"-|{ }  3^{ }  '!:-1p020p09+g09g02p3\"D\"+g02*+55%+55g3\"D\"$<{ }  +";
int t=0;int z=0;
int64 g[1242];
int d(){int s,w,i,j,h;h=z;for(;t<717;t++)if(_g[t]==';')g[z++]=_g[++t];else if(_g[t]=='}')return z-h;else if(_g[t]=='{'){t++;s=z;w=d();for(i=1;i<_g[t+1]*9025+_g[t+2]*95+_g[t+3]-291872;i++)for(j=0;j<w;g[z++]=g[s+j++]);t+=3;}else g[z++]=_g[t];return z-h;}
int64 gr(int64 x,int64 y){if(x>=0&&y>=0&&x<69&&y<18){return g[y*69+x];}else{return 0;}}
void gw(int64 x,int64 y,int64 v){if(x>=0&&y>=0&&x<69&&y<18){g[y*69+x]=v;}}
int64 td(int64 a,int64 b){ return (b==0)?0:(a/b); }
int64 tm(int64 a,int64 b){ return (b==0)?0:(a%b); }
int64*s;int q=16384;int y=0;
int64 sp(){if(!y)return 0;return s[--y];}
void sa(int64 v){if(q-y<8)s=(int64*)realloc(s,(q*=2)*sizeof(int64));s[y++]=v;}
int64 sr(){if(!y)return 0;return s[y-1];}
int main(void)
{
    int64 t0,t1,t2;
    d();
    s=(int64*)calloc(q,sizeof(int64));
    gw(9,0,0);
    gw(2,0,2);
    sa(2);
_1:
    sa(100);
    sa(10000-gr(2,0));
_2:
    if(sp()!=0)goto _3;else goto _26;
_3:
    sa(sp()-1LL);

    sa(sr());

    if(sp()!=0)goto _4;else goto _5;
_4:
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa(sp()-gr(2,0));
    goto _2;
_5:
    gw(68,1,0);
    gw(68,3,0);
    gw(68,5,0);
    sp();
    sa(sr());
    sa(59);
    sa(59);
_6:
    if(sp()!=0)goto _34;else goto _7;
_7:
    sp();
    gw(68,1,sp());
    gw(2,0,0);
    sa(100);
_8:
    gw(4,0,gr(2,0)*gr(2,0));
    t0=((gr(68,3)*gr(2,0)*20)+gr(4,0))%100;
    gw(4,0,((gr(68,3)*gr(2,0)*20)+gr(4,0))/100);
    gw(68,5,t0);
    sa(59);
    sa(59);
_9:
    if(sp()!=0)goto _33;else goto _10;
_10:
    sp();
    sa(0);
    sa(gr(9,5)-gr(9,1));
_11:
    if(sp()!=0)goto _15;else goto _12;
_12:
    sa(sp()+1LL);


    if(sr()!=60)goto _13;else goto _14;
_13:
    sa(sr());
    t0=gr(sr()+9,5);
    sa(sp()+9LL);

    sa(1);
    {int64 v0=sp();t1=gr(sp(),v0);}
    sa(t0-t1);
    goto _11;
_14:
    gw(2,0,gr(2,0)+1);
    sp();
    goto _8;
_15:
    sa(sr());
    t0=gr(sr()+9,5);
    sa(sp()+9LL);

    sa(1);
    {int64 v0=sp();t1=gr(sp(),v0);}
    t2=t0>t1?1:0;

    if((t2)!=0)goto _16;else goto _14;
_16:
    gw(2,0,gr(2,0)-1);
    gw(68,5,0);
    gw(4,0,gr(2,0)*gr(2,0));
    gw(6,0,gr(68,1)-gr(4,0));
    gw(7,0,gr(68,3)*gr(2,0)*20);
    sp();
    sa(59);
    sa(59);
_17:
    t0=0;
_18:
    if(gr(7,0)>gr(6,0))goto _32;else goto _19;
_19:
    gw(4,0,t0);
    sa(gr(6,0)-gr(7,0));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+8LL);

    sa(5);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()-1LL);

    sa(sr());

    if(sp()!=0)goto _20;else goto _21;
_20:
    sa(sr());
    gw(6,0,gr(sr()+9,1)-gr(4,0));
    gw(7,0,gr(sr()+9,3)*gr(2,0)*20);
    goto _17;
_21:
    gw(68,1,gr(68,5));
    sp();
    sa(59);
    sa(59);
_22:
    if(sp()!=0)goto _31;else goto _23;
_23:
    gw(9,3,((gr(9,3)%10)*10)+(gr(10,3)/10));
    sp();
    sa(1);
    sa(-58);
_24:
    if(sp()!=0)goto _30;else goto _25;
_25:
    gw(68,3,((gr(68,3)%10)*10)+gr(2,0));
    gw(9,0,gr(2,0)+gr(9,0));
    gw(2,0,0);
    sp();
    sa(sp()-1LL);

    sa(sr());

    if(sp()!=0)goto _8;else goto _26;
_26:
    sp();
    sa(sr()+1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()-100LL);


    if(sp()!=0)goto _28;else goto _29;
_28:
    sa(sr());
    gw(2,0,sp());
    goto _1;
_29:
    printf("%lld ", gr(9,0));
    sp();
    return 0;
_30:
    sa(sr());
    sa(sr());
    t0=(gr(sr()+9,3)%10)*10;
    sa(sp()+10LL);

    sa(3);
    {int64 v0=sp();t1=gr(sp(),v0);}
    t1/=10;
    sa(t0+t1);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+9LL);

    sa(3);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sp()+1LL);

    sa(sr()-59);
    goto _24;
_31:
    sa(sp()-1LL);

    sa(sr());
    sa(gr(sr()+9,5));
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+9LL);

    sa(1);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    goto _22;
_32:
    gw(6,0,gr(6,0)+100);
    t0++;
    goto _18;
_33:
    sa(sp()-1LL);

    sa(sr());
    sa((gr(sr()+9,3)*gr(2,0)*20)+gr(4,0));
    gw(4,0,sr()/100);
    sa(sp()%100LL);

    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+9LL);

    sa(5);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    goto _9;
_34:
    sa(sp()-1LL);

    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+9LL);

    sa(1);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+9LL);

    sa(3);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(0);
    {int64 v0=sp();int64 v1=sp();sa(v0);sa(v1);}
    sa(sp()+9LL);

    sa(5);
    {int64 v0=sp();int64 v1=sp();gw(v1,v0,sp());}
    sa(sr());
    goto _6;
}
