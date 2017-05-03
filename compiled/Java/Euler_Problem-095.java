/* transpiled with BefunCompile v1.1.0 (c) 2015 */
class Program{
private final static String _g = "Ah+LCAAAAAAABADt0OtLU3EcBvCfd7volAQp2OaKigpdYl5I54glEUqFUStZ6pBminlLnE7zSIG+8AZmC29bvskXRgsrZm257CALbGosXXI82+Skh3nZpsep03mW9qJ/"+
                                 "ot/z4sPzhe+rh90UDPbjD1ZmDcXYbd/6H0JxdH4eevNZ4akTI2EHf58cDJtdHrqfmHXGkdqOSNp/RksCH/TYpKG5ma8OdGYHK+3zH0LRp1Nvfem1htOqx8wvSsd6pjfK"+
                                 "GcZxTsbWbkU5b+yXlPV7Vs4lax8hfpJt7dsrAivn8t7pnrcHMHx8GUxfBuef6M6mI4B13J91sfnvlwAKhUKhUCgUCoVCoVAoFAqFQqHQ/948AGhZZaQyhi6LL5Y35XAT"+
                                 "hMYCr804ESkULhnKk6/1q5Ryl4RlUag1q5IajaW12603uOj3Ne8ON5poP1BvkXEmpTqpvUyj7UwkaJk5g69gFW2qMQvvKKjiEehGKY/W4GieVkW6kpDwdfEACZyIWM00"+
                                 "jVWYx4WYS2JGRLiuwrxYfqd3sc4zbQoCHoYd+SgKQXJCGvmiYmlcyTS2tLq2xj82wparCS2SP8QAqnk3yxMZa2ZWUsTZT9VdcpQa4W5oJhxmB91k8QceWyVamcVFyXSC"+
                                 "ZLdqxFkTmFQ9lsRqwC8YMKxNjxMRdAGyPWdYXUvReYsR2aHS7YUmUsTju2RdeqWcukpgaVYfa3d1BmWM8LjntIps0RWvasbdv4uvnJ/ls3+1LJXNtBq1urvXxwQmsk1P"+
                                 "TKW84dvzj2wAZ8tKjF5NWerobeeukf812oiX6noCbSULKr/PyfG7Gx0URqZV5yhzv4UCywvcLSgaj6PIzp0CqlRAj4662kIZD/nm78YqRdBW4WsGqI2kX86j6fhw8jix"+
                                 "nXhu2cUEw9zNvb2prepEYjCDcA3xWsYtvQlGnLs5wFakAnK1gxoxDecC6yOvf/jznuZb0WzwB1p9toPEGQAA";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[2043221];for(int i=0;i<2043221;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<2017&&y<1013)?g[(int)(y*2017+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<2017&&y<1013)g[(int)(y*2017+x)]=v;}
private java.io.BufferedReader ib=new java.io.BufferedReader(new java.io.InputStreamReader(System.in));
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0,t1;
private int _0(){
    gw(1,9,1000);
    gw(2,9,1017);
    gw(3,9,1000000);
    gw(1,2,0);
    gw(1,4,0);
    gw(1,5,gr(3,9));
    sa(gr(3,9)-1);
    gw((td(gr(3,9)-1,gr(1,9)))+9,tm(gr(3,9)-1,gr(1,9)),0);
    return 1;
}
private int _1(){
    sa(sr());
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa((td(sr(),gr(1,9)))+gr(2,9));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(tm(sp(),gr(1,9)));

    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr());

    if(sp()!=0)return 28;else return 2;
}
private int _2(){
    gw(1,3,1);
    sp();
    sa(1);
    return 3;
}
private int _3(){
    sa(2);
    sa(2*gr(1,3));
    sa((2*gr(1,3))<gr(3,9)?1:0);
    return 4;
}
private int _4(){
    if(sp()!=0)return 27;else return 5;
}
private int _5(){
    sp();
    sp();
    sa(sp()+1L);


    if(sr()!=gr(3,9))return 6;else return 7;
}
private int _6(){
    sa(sr());
    gw(1,3,sp());
    return 3;
}
private int _7(){
    gw(2,3,6);
    sp();
    sa(((gr((td(6,gr(1,9)))+9,tm(6,gr(1,9))))!=0)?0:1);
    return 8;
}
private int _8(){
    if(sp()!=0)return 12;else return 9;
}
private int _9(){
    sa(gr(2,3)+1);

    if((gr(2,3)+1)!=gr(3,9))return 10;else return 11;
}
private int _10(){
    sa(sr());
    gw(2,3,sp());
    sa((td(sr(),gr(1,9)))+9);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(tm(sp(),gr(1,9)));

    {long v0=sp();sa(gr(sp(),v0));}
    sa((sp()!=0)?0:1);
    return 8;
}
private int _11()throws java.io.IOException{
    System.out.print(String.valueOf(gr(1,5)));
    sp();
    return 29;
}
private int _12(){
    sa(gr(2,3));
    gw(7,0,gr(2,3));
    gw(1,2,1);
    sa((td(sr(),gr(1,9)))+gr(2,9));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(tm(sp(),gr(1,9)));

    {long v0=sp();t0=gr(sp(),v0);}
    gw(2,2,t0);
    return 13;
}
private int _13(){
    t0=gr(2,2);

    if(gr(2,2)>0)return 14;else return 9;
}
private int _14(){
    if(t0<gr(3,9))return 15;else return 9;
}
private int _15(){
    if(t0!=gr(2,3))return 16;else return 9;
}
private int _16(){
    gw(3,1,0);
    gw(3,2,0);
    sa(0);
    sa(gr(7,0)-gr(2,2));
    return 17;
}
private int _17(){
    if(sp()!=0)return 23;else return 18;
}
private int _18(){
    gw(3,1,1);
    sa(sr());
    t0=gr(1,2);
    sa(t0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    {long v0=sp();sa(sp()-v0);}

    t1=sp();
    gw(3,2,t1);

    if(gr(3,2)>gr(1,4))return 22;else return 19;
}
private int _19(){
    sp();

    if((gr(3,1))!=0)return 9;else return 20;
}
private int _20(){
    if((gr((td(gr(2,2),gr(1,9)))+9,tm(gr(2,2),gr(1,9))))==0)return 21;else return 9;
}
private int _21(){
    sa(gr(2,2));
    sa(gr(2,2));
    sa(7);
    sa(gr(1,2));
    gw(1,2,gr(1,2)+1);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa((td(sr(),gr(1,9)))+9);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(tm(sp(),gr(1,9)));

    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    gw(2,2,gr((td(gr(2,2),gr(1,9)))+gr(2,9),tm(gr(2,2),gr(1,9))));
    return 13;
}
private int _22(){
    gw(1,4,gr(3,2));
    sa(sr());
    sa(7);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    {long v0=sp();t0=gr(sp(),v0);}
    gw(1,5,t0);
    return 23;
}
private int _23(){
    sa(sr());
    sa(7);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    {long v0=sp();t0=gr(sp(),v0);}
    t0=t0<gr(1,5)?1:0;
    t0*=gr(3,1);

    if((t0)!=0)return 26;else return 24;
}
private int _24(){
    sa(sp()+1L);


    if(sr()!=gr(1,2))return 25;else return 19;
}
private int _25(){
    sa(sr());
    sa(7);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    {long v0=sp();sa(gr(sp(),v0));}
    sa(sp()-gr(2,2));
    return 17;
}
private int _26(){
    sa(sr());
    sa(7);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    {long v0=sp();t0=gr(sp(),v0);}
    gw(1,5,t0);
    return 24;
}
private int _27(){
    sa(sr());
    sa((td(sr(),gr(1,9)))+gr(2,9));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(tm(sp(),gr(1,9)));

    {long v0=sp();sa(gr(sp(),v0));}
    sa(sp()+gr(1,3));

    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa((td(sr(),gr(1,9)))+gr(2,9));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(tm(sp(),gr(1,9)));

    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sp()+1L);

    sa(sr()*gr(1,3));
    sa(sr()<gr(3,9)?1:0);
    return 4;
}
private int _28(){
    sa(sp()-1L);

    sa(sr());
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa((td(sr(),gr(1,9)))+9);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(tm(sp(),gr(1,9)));

    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    return 1;
}

public void main()throws java.io.IOException{
    int c=0;
    while(c<29){
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
    case 28:c=_28();break;
}
}
}
public static void main(String[]a){try{new Program().main();}catch(java.io.IOException e){}}
}
