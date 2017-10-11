/* transpiled with BefunCompile v1.2.0 (c) 2017 */
class Program{
private final static String _g = "Ah+LCAAAAAAABACT7+ZgAAEWhrfXHLOvOEg0PNxvdObW6ba3dTfvKrRsqvj47uLhTbqvjAK0ZLveZdbvEd4b4bo6IKr1uSKPj5HnDOeKYp/JT4327ty9127P/ylx9fss"+
                                 "7yw9alJfXvxjRpzaA3tzZoZBBh54LjleUpNx8OjifXw/jG//UeR3Npf/veL1nlOfC0VL5QLDX6+wfGr469Z25VMGZZ/3SS/698E0P3jLUk2zwO2vNWrNt2VWx1je3pp4"+
                                 "s1x1/9nu/Gx///2ODx6y/H9TN0X/++bVQq+FJur5bX09XfXX3UjpY2Vm7nFXbvTExicFJ10oruC7fSVrdlT7fv2C3M8mR3d6J3dp7F69Pjv9+Gnx/V5lWSftfMXPx9u+"+
                                 "rmvYv3G/+PO7X/jvF+35f1Y2i/f/Mv3FHVz7ExKZGADdxMcoswEAAA==";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[156000];for(int i=0;i<156000;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<1000&&y<156)?g[(int)(y*1000+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<1000&&y<156)g[(int)(y*1000+x)]=v;}
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0,t1,t2;
private int _0(){
    gw(1,0,1000);
    gw(2,0,150);
    gw(0,0,150000);
    gw(3,0,2);
    gw(0,1,32);
    gw(1,1,32);
    gw(5,0,(gr(1,0)*10)+1);
    return 1;
}
private int _1(){
    gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+1,88);
    sa(gr(3,0)+gr(3,0));
    sa((gr(3,0)+gr(3,0))<gr(0,0)?1:0);
    return 2;
}
private int _2(){
    if(sp()!=0)return 12;else return 3;
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

    sa(sp()+1L);

    {long v0=sp();t0=gr(sp(),v0);}
    t0-=32;
    return 5;
}
private int _5(){
    if((t0)!=0)return 6;else return 4;
}
private int _6(){
    if(gr(0,0)>gr(3,0))return 1;else return 7;
}
private int _7(){
    gw(3,0,0);
    gw(4,0,0);
    return 8;
}
private int _8(){
    sa(gr(3,0)+1);
    gw(3,0,gr(3,0)+1);
    sa(tm(sr(),gr(1,0)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+1L);

    {long v0=sp();t0=gr(sp(),v0);}
    t0-=88;
    return 9;
}
private int _9(){
    if((t0)!=0)return 8;else return 10;
}
private int _10(){
    t0=gr(5,0);
    t1=gr(4,0)+1;
    gw(4,0,gr(4,0)+1);
    gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+1,48);
    t2=t0-t1;

    if((t2)!=0)return 8;else return 11;
}
private int _11(){
    System.out.print(String.valueOf(gr(3,0))+" ");
    return 13;
}
private int _12(){
    sa(sr());
    sa(32);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),gr(1,0)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+1L);

    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sp()+gr(3,0));

    sa(sr()<gr(0,0)?1:0);
    return 2;
}

public void main(){
    int c=0;
    while(c<13){
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
}
}
}
public static void main(String[]a){new Program().main();}
}
