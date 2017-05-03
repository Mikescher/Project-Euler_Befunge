/* transpiled with BefunCompile v1.1.0 (c) 2015 */
class Program{
private final static String _g = "AR+LCAAAAAAABADt2slqwzAQgOFXcb1cIi8jxzpEBNEHCUkPBV110skPnwmmgdCWlDaB0PzfRaPRgpDxnJQLPJIKAAAAAAAAAAAAAAAAAIB/4OqDuZA/gvPcfIq2d3qg"+
                                 "9+RC+V5OK28lObdaiSSRGGzn/ajhbhz8HDSMu6baH/xaklkv49qt8/XtcQOz/zKdjB2i2ChjszT8IreX6/qin6zIxT0H++3a/X2O9NSC1ifbnYrTRlLQymQlNkszWBMn"+
                                 "SdOSm845J6nQGU5iV+WDRjr09rKEfVl0Rdm2reZ650xLTfuDOcnYWa+l6Kcrtp9D/bLGRJl0lygbatrvvPZc3iM4ApHVms+QMwAA";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[13200];for(int i=0;i<13200;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<400&&y<33)?g[(int)(y*400+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<400&&y<33)g[(int)(y*400+x)]=v;}
private java.io.BufferedReader ib=new java.io.BufferedReader(new java.io.InputStreamReader(System.in));
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0,t1;
private int _0(){
    gw(1,0,400);
    gw(0,0,10000);
    sa(gr(0,0)-1);
    sa(gr(0,0)-1);
    gw(2,0,gr(0,0)-1);
    return 1;
}
private int _1(){
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),2));

    sa(sr());

    if(sp()!=0)return 2;else return 16;
}
private int _2(){
    sa(sr());
    t0=gr(2,0);
    sa(t0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    {long v0=sp();sa(tm(sp(),v0));}

    t1=sp();

    if((t1)!=0)return 15;else return 3;
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
    gw(tm(gr(2,0),gr(1,0)),(td(gr(2,0),gr(1,0)))+1,sp());
    return 6;
}
private int _6(){
    sa(sr());

    if(sp()!=0)return 14;else return 7;
}
private int _7(){
    gw(0,1,0);
    gw(2,0,gr(0,0)-1);
    gw(9,0,0);
    gw(4,0,gr(tm(gr(2,0),gr(1,0)),(td(gr(2,0),gr(1,0)))+1));
    gw(5,0,gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+1));
    sp();
    sp();
    return 8;
}
private int _8(){
    if(gr(2,0)!=gr(5,0))return 9;else return 12;
}
private int _9(){
    sa(gr(2,0));
    gw(2,0,gr(2,0)-1);

    if(sp()!=0)return 10;else return 11;
}
private int _10(){
    gw(4,0,gr(tm(gr(2,0),gr(1,0)),(td(gr(2,0),gr(1,0)))+1));
    gw(5,0,gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+1));
    return 8;
}
private int _11()throws java.io.IOException{
    System.out.print(String.valueOf(gr(9,0)));
    return 17;
}
private int _12(){
    if(gr(2,0)<=gr(4,0))return 9;else return 13;
}
private int _13()throws java.io.IOException{
    System.out.print(String.valueOf(gr(2,0)));
    System.out.print(" - ");
    System.out.print(String.valueOf(gr(4,0)));
    System.out.print('\n');
    gw(9,0,gr(9,0)+gr(2,0)+gr(4,0));
    return 9;
}
private int _14(){
    sa(sp()-1L);

    sa(sr());
    sa(sr());
    gw(2,0,sp());
    return 1;
}
private int _15(){
    sa(sp()-1L);

    sa(sr());
    return 4;
}
private int _16(){
    gw(tm(gr(2,0),gr(1,0)),(td(gr(2,0),gr(1,0)))+1,1);
    return 6;
}

public void main()throws java.io.IOException{
    int c=0;
    while(c<17){
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
}
}
}
public static void main(String[]a){try{new Program().main();}catch(java.io.IOException e){}}
}
