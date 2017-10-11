/* transpiled with BefunCompile v1.2.0 (c) 2017 */
class Program{
private final static String _g = "AR+LCAAAAAAABACtkbEKwyAQhl9FNC6RNKdBSI8gnQrtE2QQU+jg6uQU8uzV0rRTBou3nAf63fdjnOeZsCpFKqJyVUTVKbMf6JNGQpaY4Y/2rHEqRUVBbxudbCJ9HxvU"+
                                 "WvC12Ep2CBbplfK4zyt2kpBiqxVDnzhWaDJdTl42TDXFkI9VI8exVQEUBAnBwACBbncqsh6+bbWwqfVegm8VeJHj9/GIp2RIH5Czud3pp8tTQxtgEB4G5ELrtPjI3KU7"+
                                 "i2MPLw0jjqk0/pHyBanoFos5AwAA";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[825];for(int i=0;i<825;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<75&&y<11)?g[(int)(y*75+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<75&&y<11)g[(int)(y*75+x)]=v;}
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0;
private int _0(){
    gw(63,2,0);
    sa(99);
    sa(99);
    sa(99);
    return 1;
}
private int _1(){
    sa(197);
    return 2;
}
private int _2(){
    sa(sr());
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa((tm(sr(),70))+5);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),70));

    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr());

    if(sp()!=0)return 18;else return 3;
}
private int _3(){
    gw(64,2,1);
    gw(2,0,0);
    sp();
    gw(1,0,sp());
    return 4;
}
private int _4(){
    gw(3,0,0);
    sa(199);
    sa(199);
    sa((gr(64,2)*gr(1,0))+gr(2,0));
    gw(2,0,td((gr(64,2)*gr(1,0))+gr(2,0),10));
    return 5;
}
private int _5(){
    sa(tm(sp(),10));

    t0=sr()+gr(3,0);
    gw(3,0,t0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa((tm(sr(),70))+5);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),70));

    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr());

    if(sp()!=0)return 17;else return 6;
}
private int _6(){
    sp();

    if(gr(3,0)>gr(2,1))return 16;else return 7;
}
private int _7(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 4;else return 8;
}
private int _8(){
    sp();
    return 9;
}
private int _9(){
    sa(sp()-1L);

    sa(sr());
    return 10;
}
private int _10(){
    if(sp()!=0)return 12;else return 11;
}
private int _11(){
    System.out.print(String.valueOf(gr(2,1))+" ");
    sp();
    return 19;
}
private int _12(){
    if(tm(sr(),10)!=0)return 14;else return 13;
}
private int _13(){
    sa(sp()-1L);

    sa(sr());
    return 10;
}
private int _14(){
    if(sr()>45)return 15;else return 9;
}
private int _15(){
    gw(63,2,0);
    sa(sr());
    sa(99);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    return 1;
}
private int _16(){
    gw(2,1,gr(3,0));
    return 7;
}
private int _17(){
    sa(sp()-1L);

    sa(sr());
    sa(sr());
    sa((tm(sr(),70))+5);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),70));

    {long v0=sp();sa(gr(sp(),v0));}
    sa(sp()*gr(1,0));

    sa(sp()+gr(2,0));

    t0=td(sr(),10);
    gw(2,0,t0);
    return 5;
}
private int _18(){
    sa(sp()-1L);
    return 2;
}

public void main(){
    int c=0;
    while(c<19){
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
}
}
}
public static void main(String[]a){new Program().main();}
}
