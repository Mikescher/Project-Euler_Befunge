/* transpiled with BefunCompile v1.2.0 (c) 2017 */
class Program{
private final static String _g = "AR+LCAAAAAAABADtlk1r4zAQhv/KRE6hRHgzIztNGYzopfceezBO2N0wUFo6hF2dsv+946Q0DTFNadmc9CALydY7X5LACXvAGkyncLd+flj9+gO3fx9Xayj7+c/H1RPM"+
                                 "5/At7rd8z8YpinPwf1M4ZyaZTCaTyWQymfNwlj/ICG7lgAkVCDigTmrUUKE6cIxBKWhKWLEnwap5U6Gt6AcY2bRy0Vo3DV7cvSuLtOAKhcnbIk62Kp2Oo4kFaAFsWadd"+
                                 "5ouuWJpPwbrZlNZbCAcC9WEqSO2FdX1g0Xxv3e7DUZtHezzXKO3yVWnxjbt4EDW4chPHvXqGai8nkUrGdm+r9vpREt37YLjta2chdcdZHqoWqeCBBUnx2v12ivOJ+3fp"+
                                 "xqer9yHN4Fv8gqWIV6QVSbTaLPttrv2MpJUrEm9fjisUyTORYrCnIo2mtQpL2QbhmpRIlqPJyCzZqCYpeUa6edV2JR3ZG8zmuMx7rMIjO0VzoXAgjGQeLZrdvsZxoD4J"+
                                 "pk+c1AGfdnZp26SAHwXc7K+uUmU3h6rGLpJXX9tQaHhDjBfnT8AoYw8AAA==";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[3939];for(int i=0;i<3939;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<101&&y<39)?g[(int)(y*101+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<101&&y<39)g[(int)(y*101+x)]=v;}
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0,t1,t2;
private int _0(){
    gw(1,0,101);
    gw(2,0,1);
    gw(4,0,101);
    gw(3,0,2);
    gw(0,2,32);
    gw(1,2,32);
    return 1;
}
private int _1(){
    gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+2,88);
    sa(gr(3,0)+gr(3,0));
    sa((gr(3,0)+gr(3,0))<gr(4,0)?1:0);
    return 2;
}
private int _2(){
    if(sp()!=0)return 27;else return 3;
}
private int _3(){
    sp();
    return 4;
}
private int _4(){
    sa(gr(3,0)+1);
    gw(3,0,gr(3,0)+1);
    sa(tm(sr(),gr(1,0)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+2L);

    {long v0=sp();t0=gr(sp(),v0);}
    t0-=32;
    return 5;
}
private int _5(){
    if((t0)!=0)return 6;else return 4;
}
private int _6(){
    if(gr(4,0)>gr(3,0))return 1;else return 7;
}
private int _7(){
    gw(3,0,0);
    sa(0);
    sa(gr(0,2)-88);
    return 8;
}
private int _8(){
    if(sp()!=0)return 9;else return 26;
}
private int _9(){
    sa(sp()+1L);


    if(sr()!=gr(4,0))return 25;else return 10;
}
private int _10(){
    sp();
    sa(gr(3,0));
    gw(5,0,gr(3,0));
    sa(sp()*gr(1,0));
    return 11;
}
private int _11(){
    sa(sp()-1L);

    sa(sr());
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),gr(1,0)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+4L);

    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr());
    return 12;
}
private int _12(){
    if(sp()!=0)return 11;else return 13;
}
private int _13(){
    gw(7,0,5000);
    gw(8,0,100);
    gw(1,1,1);
    gw(2,1,0);
    gw(3,1,0);
    sp();
    sa(1);
    return 14;
}
private int _14(){
    t0=gr(3,1)-gr(5,0);
    t1=gr(gr(3,1),2);
    gw(4,1,gr(gr(3,1),2));
    t1=t1>gr(1,1)?1:0;
    t1=(t1!=0)?0:1;
    t2=t0*t1;
    t2=(t2!=0)?0:1;

    if((t2)!=0)return 22;else return 15;
}
private int _15(){
    t0=gr(1,1)-gr(4,1);
    gw(5,1,gr(1,1)-gr(4,1));

    if((t0)!=0)return 16;else return 21;
}
private int _16(){
    gw(6,1,0);
    sa(gr(3,1));
    sa(gr(3,1)<0?1:0);
    return 17;
}
private int _17(){
    if(sp()!=0)return 18;else return 20;
}
private int _18(){
    sp();
    t0=gr(2,1);
    t1=gr(6,1);
    gw(gr(1,1),gr(3,1)+4,gr(6,1));
    t2=t0+t1;
    gw(2,1,t2);
    return 19;
}
private int _19(){
    gw(3,1,gr(3,1)+1);
    return 14;
}
private int _20(){
    sa(sr()+4);
    sa(gr(5,1));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    {long v0=sp();t0=gr(sp(),v0);}
    t0+=gr(6,1);
    gw(6,1,t0);
    sa(sp()-1L);

    sa(sr()<0?1:0);
    return 17;
}
private int _21(){
    gw(gr(1,1),gr(3,1)+4,1);
    return 19;
}
private int _22(){
    if(gr(2,1)<=gr(7,0))return 24;else return 23;
}
private int _23(){
    System.out.print(String.valueOf(gr(1,1))+" ");
    return 28;
}
private int _24(){
    sa(sp()+1L);

    sa(sr());
    gw(1,1,sp());
    gw(2,1,0);
    gw(3,1,0);
    return 14;
}
private int _25(){
    sa(sr());
    sa(tm(sr(),gr(1,0)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+2L);

    {long v0=sp();sa(gr(sp(),v0));}
    sa(sp()-88L);
    return 8;
}
private int _26(){
    sa(sr());
    sa(gr(3,0));
    gw(3,0,gr(3,0)+1);
    sa(tm(sr(),gr(1,0)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+2L);

    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    return 9;
}
private int _27(){
    sa(sr());
    sa(32);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),gr(1,0)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+2L);

    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sp()+gr(3,0));

    sa(sr()<gr(4,0)?1:0);
    return 2;
}

public void main(){
    int c=0;
    while(c<28){
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
    case 24:c=_24();break;
    case 25:c=_25();break;
    case 26:c=_26();break;
    case 27:c=_27();break;
}
}
}
public static void main(String[]a){new Program().main();}
}
