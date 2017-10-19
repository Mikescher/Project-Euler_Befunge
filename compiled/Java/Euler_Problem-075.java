/* transpiled with BefunCompile v1.3.0 (c) 2017 */
class Program{
private final static String _g = "Ah+LCAAAAAAABACT7+ZgAAEWhre3/LNvG0iwP1i/yPTlUbXVqdvzlJoi+a3Lj8v6RJl1JZacmaK7/Otuf07ZXEnrN/zZZ+cdV4iexrfrz59Tftsevr0tcO7wz0oLK678"+
                                 "PLvaHVX/Lff8K6otFRbb/W/369X9D7+oMAiXlZWJlbEzGIQaM4yCUTAKRsEoGPzgnzcjw4w9ejJ35HS6A8KTT0zfPp3dVXBWrHr2qoXeofNfZVm8eZ31+0g2a93585ut"+
                                 "w3JN9984E/ele8axTZZS1/4XxB6I/8bdWrVmWqrMqqVnDpeUFEb23t0kFaTV171P99WmM7e/nr75LancfFrm1OPBq7oXnf9bc4u/fb3/3oIH/XuqLEPeHm7aK7k69NbU"+
                                 "j1ON+IS38DrntEX0b9Q9bSi3fJNHZfS+7LDknKDAKz+17ksmzxX7nszEf/ni27IX/L83eufKdO3eW73qcUGUSaGGf9fjO+ecNvY8rjv2ff2Hw4HBfJrnv1rKzVuvl26p"+
                                 "vrMvWfi4740pH/MS7p499OejfabZ97vdb3Nqb4b/3CLxyEjzg4Hnz617Yp9s/1T2f3VU6Pf2nZ5/lcKOCtzecu+YOz+jZzvnrad7/hg+31n1vtguPv/Tkp0Vh4u/824s"+
                                 "fMX7Q1acAQDKcaipZwcAAA==";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[1515000];for(int i=0;i<1515000;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<1000&&y<1515)?g[(int)(y*1000+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<1000&&y<1515)g[(int)(y*1000+x)]=v;}
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0,t1,t2;
private int _0(){
    gw(2,0,1000);
    gw(3,0,1500000);
    sa(gr(3,0)-1);
    sa(gr(3,0));
    gw(tm(gr(3,0),gr(2,0)),(td(gr(3,0),gr(2,0)))+3,0);
    return 1;
}
private int _1(){
    if(sp()!=0)return 2;else return 3;
}
private int _2(){
    sa(sr());
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),gr(2,0)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(2,0)));

    sa(sp()+3L);

    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr()-1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    return 1;
}
private int _3(){
    gw(6,0,0);
    gw(8,0,1);
    sp();
    return 4;
}
private int _4(){
    if(((gr(8,0)*gr(8,0)*4)+(gr(8,0)*6)+2)>gr(3,0))return 21;else return 5;
}
private int _5(){
    sa((gr(8,0)+1)*(gr(8,0)+1)*2);
    sa(gr(8,0)+1);
    gw(9,0,gr(8,0)+1);
    return 6;
}
private int _6(){
    sa(sp()*gr(8,0)*2);

    sa(sp()+sp());

    t0=sp();
    t0=t0>gr(3,0)?1:0;

    if((t0)!=0)return 20;else return 7;
}
private int _7(){
    t0=(gr(9,0)*gr(9,0))-(gr(8,0)*gr(8,0));
    gw(2,1,(gr(9,0)*gr(9,0))-(gr(8,0)*gr(8,0)));
    t1=gr(8,0)*gr(9,0)*2;
    gw(3,1,gr(8,0)*gr(9,0)*2);
    t1+=(gr(9,0)*gr(9,0))+(gr(8,0)*gr(8,0));
    gw(4,1,(gr(9,0)*gr(9,0))+(gr(8,0)*gr(8,0)));
    t2=t0+t1;
    gw(6,1,t2);

    if(gr(2,1)>gr(3,1))return 19;else return 8;
}
private int _8(){
    sa(1);
    sa(gr(6,1)>gr(3,0)?1:0);
    return 9;
}
private int _9(){
    if(sp()!=0)return 18;else return 10;
}
private int _10(){
    gw(8,1,sr()*((((gr(2,1)*7)+gr(3,1))*5)+gr(4,1)));
    sa(sr()*gr(6,1));
    sa(tm(sr(),gr(2,0)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(2,0)));

    sa(sp()+3L);

    {long v0=sp();sa(gr(sp(),v0));}
    sa(sr());

    if(sp()!=0)return 13;else return 11;
}
private int _11(){
    sp();
    sa(sr()*gr(6,1));
    sa(gr(8,1));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),gr(2,0)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(2,0)));

    sa(sp()+3L);

    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    gw(6,0,gr(6,0)+1);
    return 12;
}
private int _12(){
    sa(sp()+1L);

    sa((sr()*gr(6,1))>gr(3,0)?1:0);
    return 9;
}
private int _13(){
    if((sr()-gr(8,1))!=0)return 17;else return 14;
}
private int _14(){
    sp();
    sa(1);
    return 15;
}
private int _15(){
    if(sp()!=0)return 12;else return 16;
}
private int _16(){
    sa(sr()*gr(6,1));
    sa(-1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),gr(2,0)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(2,0)));

    sa(sp()+3L);

    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    gw(6,0,gr(6,0)-1);
    return 12;
}
private int _17(){
    sa((sp()<0)?1:0);
    return 15;
}
private int _18(){
    sp();
    sa((gr(9,0)+1)*(gr(9,0)+1)*2);
    sa(gr(9,0)+1);
    gw(9,0,gr(9,0)+1);
    return 6;
}
private int _19(){
    t0=gr(2,1);
    gw(2,1,gr(3,1));
    gw(3,1,t0);
    return 8;
}
private int _20(){
    gw(8,0,gr(8,0)+1);
    return 4;
}
private int _21(){
    System.out.print(String.valueOf(gr(6,0))+" ");
    return 22;
}

public void main(){
    int c=0;
    while(c<22){
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
}
}
}
public static void main(String[]a){new Program().main();}
}
