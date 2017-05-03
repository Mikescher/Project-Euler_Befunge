/* transpiled with BefunCompile v1.1.0 (c) 2015 */
class Program{
private final static String _g = "AR+LCAAAAAAABADlUE1rwzAM/SvCTS8OaaTmc8aEXnbvcYfgho0gGB0VZfOp/e9TtpX2kELve2CBZOk9PUX8ASjyHLbHw/v49gnPX/vxCNmUv+7HD6if4EEs/hni7BU6"+
                                 "qZAprVDm/+ewWTE2fr4/EKP/ZS4mYleglMjZ5ehxZ87njbG2RtEcO0fcINuYdNSgmK1xhFK4NYotUdY6HkPFWOzCIjNgOKWckfqlBqdlL6i7Y/EnCiElH7F2PomCrW2t"+
                                 "dW56rRAJoVMK/4hHlRuUnrH00PEAcOrMi1FLuh4vew05paL5ZDN1arEfrh6Tq/nbflb17BQARO93RzjIrcNeJ5y2hvubXoi+AR19dk8gAwAA";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[800];for(int i=0;i<800;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<80&&y<10)?g[(int)(y*80+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<80&&y<10)g[(int)(y*80+x)]=v;}
private java.io.BufferedReader ib=new java.io.BufferedReader(new java.io.InputStreamReader(System.in));
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0;
private int _0(){
    gw(7,0,1);
    gw(1,0,80);
    gw(2,0,3);
    gw(4,0,240);
    gw(3,0,2);
    return 1;
}
private int _1(){
    gw(0,1,32);
    gw(1,1,32);
    gw(8,0,1073741824);
    gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+1,88);
    sa(gr(3,0)+gr(3,0));
    sa((gr(3,0)+gr(3,0))<gr(4,0)?1:0);
    return 2;
}
private int _2(){
    if(sp()!=0)return 15;else return 3;
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
    if(gr(4,0)>gr(3,0))return 1;else return 7;
}
private int _7(){
    gw(3,0,0);
    gw(5,0,0);
    return 8;
}
private int _8(){
    if(gr(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+1)!=32)return 14;else return 9;
}
private int _9(){
    t0=gr(3,0)+1;
    gw(3,0,gr(3,0)+1);
    t0-=gr(4,0);

    if((t0)!=0)return 8;else return 10;
}
private int _10(){
    gw(6,0,1000000);
    sa(0);
    sa(gr(0,1)*gr(7,0));
    sa((gr(0,1)*gr(7,0))>gr(6,0)?1:0);
    return 11;
}
private int _11(){
    if(sp()!=0)return 13;else return 12;
}
private int _12(){
    gw(7,0,sp());
    sa(sp()+1L);

    sa(sr());
    sa(1);
    {long v0=sp();sa(gr(sp(),v0));}
    sa(sp()*gr(7,0));

    sa(sr()>gr(6,0)?1:0);
    return 11;
}
private int _13()throws java.io.IOException{
    System.out.print(String.valueOf(gr(7,0)));
    sp();
    sp();
    return 16;
}
private int _14(){
    gw(gr(5,0),1,gr(3,0));
    gw(5,0,gr(5,0)+1);
    return 9;
}
private int _15(){
    sa(sr());
    sa(32);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),gr(1,0)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+1L);

    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sp()+gr(3,0));

    sa(sr()<gr(4,0)?1:0);
    return 2;
}

public void main()throws java.io.IOException{
    int c=0;
    while(c<16){
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
}
}
}
public static void main(String[]a){try{new Program().main();}catch(java.io.IOException e){}}
}
