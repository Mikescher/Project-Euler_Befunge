/* transpiled with BefunCompile v1.3.0 (c) 2017 */
class Program{
private final static String _g = "Ah+LCAAAAAAABACT7+ZgAAEWhre3z+ZddhBhuxBumLer07Pa99/ahI2J5ye5Tg1zMBViSgydIMp/3kJXVHMLb1CLw5zNM458O6Oy+3X+sXsi2/38u8PD59+L3/c3Zs+f"+
                                 "Tw8/rZL4ejzfLqZOZ1kgA0P9WmWGUTAKRsGQBw/2hzIw/N+zrSbcb9nhxGB387P3289uftEmeHdzYUlqoJnhu1eF23fmV/gs6r6zNff4xFerTsZ/Dnn5Q8d8eenUU9ef"+
                                 "vsgonqfvp2Raanpz7z3XJTVvlcp3vldnaDj+JtI1fL9d7T67XR6GfoKrv77vv/dW6PdfYYYH6rl8Fx7bWf6fMPNz4fxtq9Xan2/unt1n6cj/7vQDV8tfv05LN+tNK80T"+
                                 "mzj754p39mk7V766LPL1ZmHeLD21syv8DG8ufsHM8D1z+sRTz11/fnl5svv982vWpt/XxFec//qtkWdflcqL54vWJTAfuL9ubv7m33/8yuLvPPuz+Gvl/dQp1TxvpjIf"+
                                 "UMzdNWPZjCURMgWXjk/64RXC3uCcNTuT7/zlu7JfrthPsrPQjLvzcvbhb2v6b1jXrv559+DsUvHTDzXkjxVtvWvhb/g+ydDLvPvH0TJR+/k+YQ8ZHzC8y+l8vuVe+P2X"+
                                 "r/bIuqy7e9oj9L/RzU36j+O/z9m8Ny6hftJx3a4Xn26o+YeeXXR6qf30/3l3857fLrtXHsTwQCHv0888if33zO5zvtn+naP538FdM0J/8iV+S7az11v3+aePHXuD/TLb"+
                                 "Lzva48LYGequmxvfy89nWMDPAADs11TW6AUAAA==";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[1024000];for(int i=0;i<1024000;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<2000&&y<512)?g[(int)(y*2000+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<2000&&y<512)g[(int)(y*2000+x)]=v;}
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0;
private int _0(){
    gw(1,0,2000);
    gw(2,0,500);
    gw(0,0,1000000);
    gw(3,0,2);
    gw(0,3,32);
    gw(1,3,32);
    return 1;
}
private int _1(){
    gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+1,88);
    sa(gr(3,0)+gr(3,0));
    sa((gr(3,0)+gr(3,0))<gr(0,0)?1:0);
    return 2;
}
private int _2(){
    if(sp()!=0)return 31;else return 3;
}
private int _3(){
    sp();
    return 4;
}
private int _4(){
    sa(gr(3,0)+1);
    sa(gr(3,0)+1);
    gw(3,0,gr(3,0)+1);
    sa(tm(sp(),gr(1,0)));

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
    gw(4,0,0);
    gw(3,0,0);
    return 8;
}
private int _8(){
    sa(gr(3,0)+1);
    sa(gr(3,0)+1);
    gw(3,0,gr(3,0)+1);
    sa(tm(sp(),gr(1,0)));

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
    sa(gr(3,0));
    sa(gr(4,0));
    sa(gr(4,0));
    gw(4,0,gr(4,0)+1);
    sa(tm(sp(),gr(1,0)));

    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+1L);

    {long v0=sp();long v1=sp();gw(v1,v0,sp());}

    if(gr(0,0)>gr(3,0))return 8;else return 11;
}
private int _11(){
    sa(0);
    sa(gr(4,0)-1);
    sa(gr(4,0)-1);
    gw(4,0,gr(4,0)-1);
    sa(tm(sp(),gr(1,0)));

    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+1L);

    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    gw(6,0,0);
    gw(7,0,-1);
    gw(8,0,0);
    gw(9,0,1);
    return 12;
}
private int _12(){
    sa(gr(7,0)+1);
    sa(gr(7,0)+1);
    gw(7,0,gr(7,0)+1);
    sa(tm(sp(),gr(1,0)));

    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+1L);

    {long v0=sp();t0=gr(sp(),v0);}
    t0+=gr(8,0);

    if(t0<gr(0,0))return 30;else return 13;
}
private int _13(){
    gw(7,0,gr(7,0)-1);
    return 14;
}
private int _14(){
    sa(gr(8,0));
    sa(gr(8,0));
    gw(5,0,gr(4,0));
    return 15;
}
private int _15(){
    t0=gr(5,0);
    sa(sp()-gr(tm(gr(5,0),gr(1,0)),(td(gr(5,0),gr(1,0)))+1));


    if(sp()!=0)return 17;else return 16;
}
private int _16(){
    System.out.print(String.valueOf((long)(sp()))+" ");
    return 32;
}
private int _17(){
    if((t0)!=0)return 29;else return 18;
}
private int _18(){
    sp();

    if(0>(gr(6,0)+gr(9,0)))return 19;else return 23;
}
private int _19(){
    if(gr(9,0)!=1)return 20;else return 22;
}
private int _20(){
    gw(8,0,gr(8,0)-gr(tm(gr(7,0),gr(1,0)),(td(gr(7,0),gr(1,0)))+1));
    gw(7,0,gr(7,0)-1);
    return 21;
}
private int _21(){
    gw(9,0,gr(9,0)*-1);
    return 14;
}
private int _22(){
    gw(8,0,gr(8,0)-gr(tm(gr(6,0),gr(1,0)),(td(gr(6,0),gr(1,0)))+1));
    gw(6,0,gr(6,0)+1);
    return 21;
}
private int _23(){
    if(gr(9,0)!=1)return 28;else return 24;
}
private int _24(){
    sa((gr(8,0)-gr(tm(gr(6,0),gr(1,0)),(td(gr(6,0),gr(1,0)))+1))+gr(tm(gr(7,0)+1,gr(1,0)),(td(gr(7,0)+1,gr(1,0)))+1));
    sa(((gr(8,0)-gr(tm(gr(6,0),gr(1,0)),(td(gr(6,0),gr(1,0)))+1))+gr(tm(gr(7,0)+1,gr(1,0)),(td(gr(7,0)+1,gr(1,0)))+1))<gr(0,0)?1:0);
    return 25;
}
private int _25(){
    if(sp()!=0)return 27;else return 26;
}
private int _26(){
    sp();
    return 19;
}
private int _27(){
    gw(8,0,sp());
    t0=gr(9,0);
    gw(6,0,gr(9,0)+gr(6,0));
    t0+=gr(7,0);
    gw(7,0,t0);
    return 14;
}
private int _28(){
    sa((gr(8,0)+gr(tm(gr(6,0)-1,gr(1,0)),(td(gr(6,0)-1,gr(1,0)))+1))-gr(tm(gr(7,0),gr(1,0)),(td(gr(7,0),gr(1,0)))+1));
    sa(((gr(8,0)+gr(tm(gr(6,0)-1,gr(1,0)),(td(gr(6,0)-1,gr(1,0)))+1))-gr(tm(gr(7,0),gr(1,0)),(td(gr(7,0),gr(1,0)))+1))<gr(0,0)?1:0);
    return 25;
}
private int _29(){
    gw(5,0,gr(5,0)-1);
    sa(sr());
    return 15;
}
private int _30(){
    gw(8,0,t0);
    return 12;
}
private int _31(){
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
public static void main(String[]a){new Program().main();}
}
