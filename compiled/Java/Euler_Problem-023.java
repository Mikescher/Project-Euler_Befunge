/* transpiled with BefunCompile v1.3.0 (c) 2017 */
class Program{
private final static String _g = "Ah+LCAAAAAAABACT7+ZgAAEWhrd3z/Y1GQgc+BiuyCV+Qs95Kafispvshq8SJ8dVPzpy+D3DbqGJL3YVltr/23+kRGexwtLL93KU/qh4MxAPdkx0/x+vve7ZrP4HBlW+"+
                                 "4mvliy3rZ0fv0Tu1RU9lzRrfyyEqHRXhNle3XixI/rSrVOqX76Y7715Nbckxlbm+vbD4J8uOxm18kROrNffMUJG6tXffsuAmzaJsdf8KGa6Ji3+/4Qvc2Dvre+OpPRH6"+
                                 "qUZtMz177G1PTIhVnVe2Y6eUyfVKu43Zvxd+iN+/7f+Jl1mBXgVLK2KFTbJ+B9QYmey0e6MmaWW8unOb/5bYRbJCb00CrY3+3qq9PddB7i93/dK3Pw8nX/yZknSH9e+N"+
                                 "mB8MfXNF5t6ssi8PjpTY1zx51f2Hr55dm7lOJDOhzSrlmNUU/dmy1bets0udrV9Gsa8s2Zyyx0X088NzMar/fj5dkb0muOdY7R7GFXMF1Rs6GRgAPr8OZ4ABAAA=";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[35200];for(int i=0;i<35200;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<400&&y<88)?g[(int)(y*400+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<400&&y<88)g[(int)(y*400+x)]=v;}
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0,t1,t2;
private int _0(){
    gw(1,0,400);
    gw(0,0,30000);
    sa(gr(0,0)-1);
    sa(0);
    sa((gr(0,0)-1)/2);
    sa((gr(0,0)-1)/2);
    gw(2,0,gr(0,0)-1);
    return 1;
}
private int _1(){
    if(sp()!=0)return 2;else return 23;
}
private int _2(){
    t0=gr(2,0);
    sa(sr());
    sa(t0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    {long v0=sp();sa(tm(sp(),v0));}

    t1=sp();

    if((t1)!=0)return 22;else return 3;
}
private int _3(){
    sa(sr());
    gw(3,0,sp());
    sa(sp()+sp());

    sa(gr(3,0)-1);
    sa(gr(3,0)-1);
    return 4;
}
private int _4(){
    if(sp()!=0)return 2;else return 5;
}
private int _5(){
    sp();
    sa((sp()>gr(2,0))?1:0);

    gw(tm(gr(2,0),gr(1,0)),(td(gr(2,0),gr(1,0)))+1,sp());
    return 6;
}
private int _6(){
    sa(sr());

    if(sp()!=0)return 21;else return 7;
}
private int _7(){
    gw(0,1,0);
    gw(4,0,gr(0,0));
    sp();
    sp();
    return 8;
}
private int _8(){
    t2=gr(4,0)-1;
    gw(4,0,gr(4,0)-1);

    if((t2)!=0)return 14;else return 9;
}
private int _9(){
    gw(8,0,0);
    gw(2,0,gr(0,0));
    return 10;
}
private int _10(){
    gw(2,0,gr(2,0)-1);

    if((gr(tm(gr(2,0),gr(1,0)),(td(gr(2,0),gr(1,0)))+1)/2)!=0)return 12;else return 11;
}
private int _11(){
    gw(8,0,gr(8,0)+gr(2,0));
    return 12;
}
private int _12(){
    if((gr(2,0))!=0)return 10;else return 13;
}
private int _13(){
    System.out.print(String.valueOf(gr(8,0))+" ");
    return 24;
}
private int _14(){
    if((gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+1)%2)!=0)return 15;else return 8;
}
private int _15(){
    gw(5,0,gr(4,0)+1);
    return 16;
}
private int _16(){
    t2=gr(5,0)-1;
    gw(5,0,gr(5,0)-1);

    if((t2)!=0)return 17;else return 8;
}
private int _17(){
    if((gr(tm(gr(5,0),gr(1,0)),(td(gr(5,0),gr(1,0)))+1)%2)!=0)return 18;else return 16;
}
private int _18(){
    if((gr(4,0)+gr(5,0))>gr(0,0))return 20;else return 19;
}
private int _19(){
    gw(tm(gr(4,0)+gr(5,0),gr(1,0)),(td(gr(4,0)+gr(5,0),gr(1,0)))+1,(gr(tm(gr(4,0)+gr(5,0),gr(1,0)),(td(gr(4,0)+gr(5,0),gr(1,0)))+1)%2)+2);
    return 16;
}
private int _20(){
    t2=0;
    return 16;
}
private int _21(){
    sa(sp()-1L);

    sa(sr());
    sa(sr());
    gw(2,0,sp());
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()/2L);

    sa(sr());
    return 1;
}
private int _22(){
    sa(sp()-1L);

    sa(sr());
    return 4;
}
private int _23(){
    gw(tm(gr(2,0),gr(1,0)),(td(gr(2,0),gr(1,0)))+1,1>gr(2,0)?1:0);
    return 6;
}

public void main(){
    int c=0;
    while(c<24){
    switch(c){
    case 0:c=_0();break;
    case 1:c=_1();break;
    case 2:c=_2();break;
    case 3:c=_3();break;
    case 4:c=_4();break;
    case 5:c=_5();break;
    case 6:c=_6();break;
    case 7:c=_7();break;
    case 8:c=_8();break;
    case 9:c=_9();break;
    case 10:c=_10();break;
    case 11:c=_11();break;
    case 12:c=_12();break;
    case 13:c=_13();break;
    case 14:c=_14();break;
    case 15:c=_15();break;
    case 16:c=_16();break;
    case 17:c=_17();break;
    case 18:c=_18();break;
    case 19:c=_19();break;
    case 20:c=_20();break;
    case 21:c=_21();break;
    case 22:c=_22();break;
    case 23:c=_23();break;
}
}
}
public static void main(String[]a){new Program().main();}
}
