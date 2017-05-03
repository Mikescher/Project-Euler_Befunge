/* transpiled with BefunCompile v1.1.0 (c) 2015 */
class Program{
private final static String _g = "AR+LCAAAAAAABAC1UcFuwyAM/RV36S5F2WxYTEAR2mfsUKVHrpw49eNnQ5tW6y6rNEfB5snPzzYVnjSzGTgKwDMCyc9BvJW7RfBsBQ/NO5ofeTyDJ8nTXPEsPBKMGDuP"+
                                 "GLyjB553gkuuo+7br3U4gA1aq/fz2OcMblYNC/bivWC9ltQI+CtvFty1GXQW3HTdjB2zc+v1J+/ZfQ6b/Y33rN7XZv+o96SlaTIp0jHWFCV8J+OwaPT6cWA2xmJBixkF"+
                                 "zvkFX8Y4YWGuyj3HkcoClTJ6LEadHmxv8dRj7vECbai0B+8PazITZjJFyOJYjlqXW2d3YYG7ZZyPI8VWdWqlRXmh805RZRUIxjBDwQW8fBerJg2wHwAHCO0sGiwp6pA+"+
                                 "D+sJYsAcyYRV1Mq2H0XH3VBPMbbcIL0eeepBPuyEGWPtyQbwyltLa+MIGa2uqd+yuIllo7nd42VGBvvwLntMF7030PJJn8HenkE2zutN72qf+9M67MaMIRpaWiNepQpy"+
                                 "HIWYMzpZ2/IN4Pew4JgEAAA=";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[1176];for(int i=0;i<1176;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<56&&y<21)?g[(int)(y*56+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<56&&y<21)g[(int)(y*56+x)]=v;}
private java.io.BufferedReader ib=new java.io.BufferedReader(new java.io.InputStreamReader(System.in));
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0,t1;
private int _0(){
    gw(10,10,1);
    sa(9);
    return 1;
}
private int _1(){
    sa(sr());
    sa(1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr());
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sp()-1L);

    sa(sr());
    return 2;
}
private int _2(){
    if(sp()!=0)return 1;else return 3;
}
private int _3(){
    gw(3,0,5);
    gw(2,0,48);
    sp();
    sa(49);
    return 4;
}
private int _4(){
    sa(0);
    sa(gr(gr(2,0),gr(3,0))-48);
    gw(5,0,gr(gr(2,0),gr(3,0))-48);
    sa(sp()+12L);

    sa(7);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(0);
    sa(gr(gr(2,0)+1,gr(3,0))-48);
    gw(6,0,gr(gr(2,0)+1,gr(3,0))-48);
    sa(sp()+12L);

    sa(7);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(0);
    sa(gr(gr(2,0)+2,gr(3,0))-48);
    gw(7,0,gr(gr(2,0)+2,gr(3,0))-48);
    sa(sp()+12L);

    sa(7);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    gw(gr(5,0)+1,gr(6,0)+1,2);
    gw(gr(5,0)+1,gr(7,0)+1,2);
    gw(gr(6,0)+1,gr(7,0)+1,2);
    gw(gr(7,0)+1,gr(5,0)+1,0);
    gw(gr(7,0)+1,gr(6,0)+1,0);
    gw(gr(6,0)+1,gr(5,0)+1,0);
    sa(sr()-1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}

    if(sp()!=0)return 18;else return 5;
}
private int _5(){
    gw(9,0,0);
    sp();
    sa(9);
    sa(gr(21,7));
    return 6;
}
private int _6(){
    if(sp()!=0)return 7;else return 17;
}
private int _7(){
    sa(sr()-1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa((sp()!=0)?0:1);

    if(sp()!=0)return 9;else return 8;
}
private int _8(){
    sa(sr()+12);
    sa(7);
    {long v0=sp();sa(gr(sp(),v0));}
    return 6;
}
private int _9(){
    sa(sp()+1L);
    return 10;
}
private int _10(){
    if(sr()-gr(9,0)==0)return 13;else return 11;
}
private int _11(){
    sa(sr());
    sa(sr());
    sa(sr()+12);
    sa(9);
    {long v0=sp();sa(gr(sp(),v0));}
    sa(sp()+1L);

    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+11L);

    sa(9);
    {long v0=sp();sa(gr(sp(),v0));}
    sa(sp()+1L);

    {long v0=sp();t0=gr(sp(),v0);}
    sa(sp()*t0);

    t1=sp();
    t1=(t1!=0)?0:1;

    if((t1)!=0)return 9;else return 12;
}
private int _12(){
    sa(sr());
    sa(sr());
    sa(sr()+12);
    sa(9);
    {long v0=sp();t0=gr(sp(),v0);}
    gw(2,0,t0);
    sa(sp()+11L);

    sa(9);
    {long v0=sp();sa(gr(sp(),v0));}
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+12L);

    sa(9);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sp()-1L);

    sa(sr());
    sa(gr(2,0));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+12L);

    sa(9);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    return 10;
}
private int _13()throws java.io.IOException{
    System.out.print(String.valueOf(gr(12,9)));
    sp();
    sa(1);
    sa((1-gr(9,0)!=0)?0:1);
    return 14;
}
private int _14(){
    if(sp()!=0)return 15;else return 16;
}
private int _15(){
    sp();
    return 19;
}
private int _16()throws java.io.IOException{
    sa(sr()+12);
    sa(9);
    {long v0=sp();t0=gr(sp(),v0);}
    System.out.print(String.valueOf(t0));
    sa(sp()+1L);

    sa((sr()-gr(9,0)!=0)?0:1);
    return 14;
}
private int _17(){
    sa(sr());
    sa(gr(9,0));
    gw(9,0,gr(9,0)+1);
    sa(sp()+12L);

    sa(9);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    return 7;
}
private int _18(){
    t0=(td(sr(),10))+1;
    gw(3,0,t0);
    t0=((tm(sr(),10))*4)+12;
    gw(2,0,t0);
    return 4;
}

public void main()throws java.io.IOException{
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
public static void main(String[]a){try{new Program().main();}catch(java.io.IOException e){}}
}
