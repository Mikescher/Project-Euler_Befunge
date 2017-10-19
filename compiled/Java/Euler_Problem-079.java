/* transpiled with BefunCompile v1.3.0 (c) 2017 */
class Program{
private final static String _g = "AR+LCAAAAAAABAC1Uctu4zAM/BWmzl6iGiWlmnrAEPYz9hA4R1110ikfX1JKnaLppQGWhkVqwOGQVIMnzewGjiJwQCD5OYq3crcInq3gsXtH4ZHHATxJnuaKZ+GRYMQ4"+
                                 "eMTgHT3wvBNcch0N33+twxFs1Fqjn8c+A7igGhbszXvBRi2pEfFHXhDc9Rl0Ftx1XcCB2dB7/c57dp/Tbr/jPav3b7f/qPek5WUxOdE5tZwkfCPjsGr05/3EbIzFihYL"+
                                 "ClzKC77MacHK3JR7TTPVFRoV9FiNOj3Y3uNlxDziFfpQ+Qjen7ZsFixkqpDFsRytrffOvoQVvizjep4p9apLLy3KK10PiiqrQjSGGSqu4OW7WTN5guMEOEHsZ9VgzUmH"+
                                 "9GXaLpAilkQmbqJW9/0oOh+mdkmp50bp9czLCMrpIMyU2kg2gJ+8rfY2zlDQ6prGrYhbWDZa+j3dZmSwD+9yxHzT43AyDbI+g70/g2yct7vep/09XrbpMBeMydCrLHGr"+
                                 "XqUqcpqFWAo6Wdv6AUItDRCYBAAA";
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
    sa(9);
    return 1;
}
private int _1(){
    if(sp()!=0)return 2;else return 3;
}
private int _2(){
    sa(sr());
    sa(1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr());
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sp()-1L);

    sa(sr());
    return 1;
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
    sa(gr(gr(2,0),gr(3,0))-36);
    gw(5,0,gr(gr(2,0),gr(3,0))-48);
    sa(7);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(0);
    sa(gr(gr(2,0)+1,gr(3,0))-36);
    gw(6,0,gr(gr(2,0)+1,gr(3,0))-48);
    sa(7);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(0);
    sa(gr(gr(2,0)+2,gr(3,0))-36);
    gw(7,0,gr(gr(2,0)+2,gr(3,0))-48);
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

    if(sp()!=0)return 8;else return 9;
}
private int _8(){
    sa(gr(sr()+12,7));
    return 6;
}
private int _9(){
    sa(sp()+1L);
    return 10;
}
private int _10(){
    if((sr()-gr(9,0))!=0)return 11;else return 13;
}
private int _11(){
    sa(sr());
    sa(sr());
    sa(gr(sr()+12,9)+1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+11L);

    sa(9);
    {long v0=sp();sa(gr(sp(),v0));}
    sa(sp()+1L);

    {long v0=sp();t0=gr(sp(),v0);}
    sa(sp()*t0);

    t1=sp();

    if((t1)!=0)return 12;else return 9;
}
private int _12(){
    sa(sr());
    sa(sr());
    gw(2,0,gr(sr()+12,9));
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
private int _13(){
    System.out.print(String.valueOf((char)(gr(12,9)+48)));
    sp();
    sa(1);
    sa(1-gr(9,0));
    return 14;
}
private int _14(){
    if(sp()!=0)return 16;else return 15;
}
private int _15(){
    sp();
    return 19;
}
private int _16(){
    System.out.print(String.valueOf((char)(gr(sr()+12,9)+48)));
    sa(sp()+1L);

    sa(sr()-gr(9,0));
    return 14;
}
private int _17(){
    sa(sr());
    sa(gr(9,0)+12);
    gw(9,0,gr(9,0)+1);
    sa(9);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    return 7;
}
private int _18(){
    gw(3,0,(sr()/10)+1);
    gw(2,0,((sr()%10)*4)+12);
    return 4;
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
