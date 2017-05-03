/* transpiled with BefunCompile v1.1.0 (c) 2015 */
class Program{
private final static String _g = "AR+LCAAAAAAABADt28tSpDAUgOFXiYIbUow5BBRTVGreYLazoGh22WbFaubdJ9Ci7aV1yrlg6/91VYtJ7IqLJOccmkl9TxSAT+lbsvUcAADA/5QBAAAAAAAAAAAAAAAA"+
                                 "AAAAAIB3b+vnDwBsZ+v9BwAAAAAAAAAAAAAAAAAAAAAAvG7r5w8AnIYp6la3l8E0/UV6c724qO1lt/W8ALyNPx9Hda6LysTzn+N5YU1sXbF/1SZWbTG/mnRlgndn2bST"+
                                 "0tUm9K4x4aJPb2rY+n8A8EZTlLqKYrUEY6NUVTrkW6mOjM67yZVlkDqITePTBac/cLqm413PLu1HFYPdkJVW63HeElIucJcbzJvE8a2hiw/GsocA2/BWgmgrUZm2KoJz"+
                                 "tYT+shdd1Eqi6Lk1mib1K5+60mhrQiWh1GNKBtJ1akntZSnjvns8u21UQ2q9SxMurZ7HjVrbMht29fI5t39LBgG8O8N6Sq8N82l9eFZ71Ui4X+Fpp9Bhv3/UEu0LkQWA"+
                                 "dyHl/03K/aWZawB9Suuj1EX6Wbugi+qg2h9ENfFxU/No0PpJZf9S+A/gffDNEomLLlM4/7Dr8QH+SpjOegdOTVrk++q/WBYw8Mn4Z1J4J/pJa1RrYi86XRXpIo2pJIxr"+
                                 "3EAVDzgxU7RiojXmmb7fjQf8shFE1j9w6rzV4Wq+JXh45y5eLeGAmtMFn+dU9oEPw0uc/LWEUqlsUtPTZ4IOAoHUme+mbOyDtNQLgNN3PZlucMvX97qUxR/e37taWtX9"+
                                 "7T0X5cp1yrdpu/ix9cQB/BFvpBy8W4P9QU273Jn16R61j/4PBizf43NuWfr51pMH8OeGFNGXwVTpfO+8u97X9FuJzkvpRCt1f9Jnc5k/z5fQXzabMIC/6O4ovy3i5z5T"+
                                 "19m8xGOmurwzSj14ZKdPDZr8Hzh9kzFHlvL6BMD6e3/Bmgc+lkkfjeRZ7sAH5527kXhY4NM3Epw1lPiBz8znX/KvW08CwL/xC0UCinQAyAAA";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[51200];for(int i=0;i<51200;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<1024&&y<50)?g[(int)(y*1024+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<1024&&y<50)g[(int)(y*1024+x)]=v;}
private java.io.BufferedReader ib=new java.io.BufferedReader(new java.io.InputStreamReader(System.in));
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0,t1,t2,t3,t4;
private int _0(){
    gw(2,0,12288);
    gw(3,0,12000);
    gw(4,0,281474976710656L);
    gw(5,0,1024);
    sa(gr(2,0));
    sa(((gr(2,0))!=0)?0:1);
    return 1;
}
private int _1(){
    if(sp()!=0)return 2;else return 31;
}
private int _2(){
    gw(1,16,2);
    gw(2,1,2);
    gw(3,1,gr(3,0)+1);
    gw(4,1,2);
    gw(3,1,gr(3,1)+1);
    sp();
    return 3;
}
private int _3(){
    t0=gr(0,16);
    gw(4,1,(td(gr(4,1),gr(0,16)))*(gr(0,16)+1));
    t0++;
    gw(0,16,t0);
    gw(5,1,0);
    return 4;
}
private int _4(){
    if(gr(4,1)>(gr(3,1)+(gr(3,0)-gr(2,1))))return 5;else return 28;
}
private int _5(){
    t0=gr(tm(gr(5,1),gr(5,0)),(td(gr(5,1),gr(5,0)))+16);
    gw(4,1,td(gr(4,1),gr(tm(gr(5,1),gr(5,0)),(td(gr(5,1),gr(5,0)))+16)));
    t1=gr(3,1);
    t2=t1-t0;
    gw(3,1,t2);
    gw(tm(gr(5,1),gr(5,0)),(td(gr(5,1),gr(5,0)))+16,gr(tm(gr(5,1)+1,gr(5,0)),(td(gr(5,1)+1,gr(5,0)))+16));
    t0=gr(tm(gr(5,1),gr(5,0)),(td(gr(5,1),gr(5,0)))+16);
    gw(4,1,gr(4,1)*gr(tm(gr(5,1),gr(5,0)),(td(gr(5,1),gr(5,0)))+16));
    t1=gr(3,1);
    t2=t1+t0;
    gw(3,1,t2);
    gw(5,1,gr(5,1)+1);

    if(gr(5,1)!=(gr(3,0)+1))return 6;else return 8;
}
private int _6(){
    gw(3,1,gr(3,1)+1);
    t0=gr(tm(gr(5,1),gr(5,0)),(td(gr(5,1),gr(5,0)))+16);
    t1=gr(tm(gr(5,1),gr(5,0)),(td(gr(5,1),gr(5,0)))+16);
    gw(tm(gr(5,1),gr(5,0)),(td(gr(5,1),gr(5,0)))+16,gr(tm(gr(5,1),gr(5,0)),(td(gr(5,1),gr(5,0)))+16)+1);
    t2=gr(4,1);
    t3=td(t2,t1);
    gw(4,1,t3);
    t0++;
    t0*=gr(4,1);
    gw(4,1,t0);

    if(gr(5,1)>gr(2,1))return 7;else return 4;
}
private int _7(){
    gw(2,1,gr(5,1));
    return 4;
}
private int _8(){
    gw(0,3,0);
    gw(1,3,0);
    gw(7,1,-1);
    sa(5);
    sa(0);
    sa(gr(0,3));
    sa(gr(0,3)-gr(7,1));
    return 9;
}
private int _9(){
    if(sp()!=0)return 17;else return 10;
}
private int _10(){
    sp();
    sa(sr());
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),gr(5,0)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(5,0)));

    sa(sp()+3L);

    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    return 11;
}
private int _11(){
    sa(sp()+1L);


    if(sr()!=gr(2,0))return 12;else return 13;
}
private int _12(){
    sa(sr());
    sa(tm(sr(),gr(5,0)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(5,0)));

    sa(sp()+3L);

    {long v0=sp();sa(gr(sp(),v0));}
    sa(sr()-gr(7,1));
    return 9;
}
private int _13(){
    gw(9,1,0);
    sp();
    t4=gr(0,3);
    return 14;
}
private int _14(){
    sa(gr(9,1));

    if(gr(9,1)!=gr(3,0))return 16;else return 15;
}
private int _15()throws java.io.IOException{
    sp();
    System.out.print(String.valueOf(t4));
    sp();
    return 32;
}
private int _16(){
    sa(sp()+1L);

    sa(sr());
    sa(sr());
    gw(9,1,sp());
    sa(tm(sp(),gr(5,0)));

    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(5,0)));

    sa(sp()+3L);

    {long v0=sp();t0=gr(sp(),v0);}
    t4+=t0;
    return 14;
}
private int _17(){
    if(sr()>gr(7,1))return 18;else return 19;
}
private int _18(){
    gw(7,1,sp());
    return 11;
}
private int _19(){
    gw(8,1,sp());
    sa(sr());
    return 20;
}
private int _20(){
    sa(sp()-1L);


    if((sr()+1)!=0)return 21;else return 24;
}
private int _21(){
    sa(sr());
    sa(tm(sr(),gr(5,0)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(5,0)));

    sa(sp()+3L);

    {long v0=sp();sa(gr(sp(),v0));}
    sa(sr());
    sa(sr());

    if(sp()!=0)return 22;else return 27;
}
private int _22(){
    sa(sp()-gr(8,1));


    if(sp()!=0)return 23;else return 26;
}
private int _23(){
    sa((sp()<gr(8,1))?1:0);


    if(sp()!=0)return 24;else return 25;
}
private int _24(){
    sp();
    return 11;
}
private int _25(){
    sa(sr());
    gw(6,1,sp());
    sa(sr()+1);
    sa(tm(sr(),gr(5,0)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(5,0)));

    sa(sp()+3L);

    {long v0=sp();t0=gr(sp(),v0);}
    gw(tm(gr(6,1)+1,gr(5,0)),(td(gr(6,1)+1,gr(5,0)))+3,gr(tm(gr(6,1),gr(5,0)),(td(gr(6,1),gr(5,0)))+3));
    gw(tm(gr(6,1),gr(5,0)),(td(gr(6,1),gr(5,0)))+3,t0);
    return 20;
}
private int _26(){
    sp();
    sa(sp()+1L);

    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),gr(5,0)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(5,0)));

    sa(sp()+3L);

    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    return 11;
}
private int _27(){
    sp();
    sp();
    return 25;
}
private int _28(){
    if((((gr(3,0)-(gr(3,1)-gr(4,1)))>1?1:0)+(gr(4,1)<=gr(3,1)?1:0)+(gr(tm(gr(3,0)-(gr(3,1)-gr(4,1)),gr(5,0)),(td(gr(3,0)-(gr(3,1)-gr(4,1)),gr(5,0)))+3)>gr(4,1)?1L:0L))!=3)return 29;else return 30;
}
private int _29(){
    gw(3,1,gr(3,1)+1);
    return 3;
}
private int _30(){
    gw(tm(gr(3,0)-(gr(3,1)-gr(4,1)),gr(5,0)),(td(gr(3,0)-(gr(3,1)-gr(4,1)),gr(5,0)))+3,gr(4,1));
    gw(3,1,gr(3,1)+1);
    return 3;
}
private int _31(){
    sa(sp()-1L);

    sa(sr());
    sa(gr(4,0));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),gr(5,0)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(5,0)));

    sa(sp()+3L);

    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),gr(5,0)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(5,0)));

    sa(sp()+8L);

    sa(sp()+8L);

    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa((sp()!=0)?0:1);
    return 1;
}

public void main()throws java.io.IOException{
    int c=0;
    while(c<32){
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
    case 29:c=_29();break;
    case 30:c=_30();break;
    case 31:c=_31();break;
}
}
}
public static void main(String[]a){try{new Program().main();}catch(java.io.IOException e){}}
}
