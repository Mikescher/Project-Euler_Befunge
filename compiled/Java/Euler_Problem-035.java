/* transpiled with BefunCompile v1.3.0 (c) 2017 */
class Program{
private final static String _g = "Ah+LCAAAAAAABACT7+ZgAAEWhre3D+ZddhBguBBfOPeJkPnZXcfWbtISE38nU71hEtcKnYVKa7iKXh3fvM7LlU+TsVPqyvclFY+/VojOV9sslb/Z/XTqt3ffTi9/zR+/"+
                                 "efv9vHX5m48W/Pv37Fdx2FVJsPkbrrMwjIJRMAqGPKjYaAQkE0p8/xnWh55/vpGndu6+848zXzxX/LI89MVnnf6Fr06vus+38faG4mz5sIdJU+R5Gd7ckBPbpp6ff23y"+
                                 "ar2Q2Ak3GBNcfOtmhi/0flppnn05MVK01ir/0vIOxZK3V50fpOyeybc5VTD46b/imumnfhy9O4OfkcFk9YWn6zf/+fHjydn+naXxIaf1przVkU2yztmznKtmb73gV0uG"+
                                 "nucH/n6rLjJj+LP52uy3h7Oz3bv1WuxCNmrsDvDVP3TZ/J/mf26GBJ/9657NP3P1bGM3A8P+pZL3vKV/3XmU1307dd+MNeYb1zjHbyuN1Xl8MWV35qOXORLJtfY8nw8f"+
                                 "rYzm7y3SNLtnenmzyZzlro/nLdtp8UmZ+UD3NRmhzzeMy6+3W+md0ltSc791c2Tg9cjdPu633zJ8uJ8R9LBObtfkx1cDdq93kp+Vc8tns/rtJ4wN6Zfe8LDPXie9Uobh"+
                                 "X9v7FSrdxQ77+RkAAhzLy4wFAAA=";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[1032000];for(int i=0;i<1032000;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<2000&&y<516)?g[(int)(y*2000+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<2000&&y<516)g[(int)(y*2000+x)]=v;}
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
    gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+3,88);
    sa(gr(3,0)+gr(3,0));
    sa((gr(3,0)+gr(3,0))<gr(0,0)?1:0);
    return 2;
}
private int _2(){
    if(sp()!=0)return 23;else return 3;
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

    sa(sp()+3L);

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
    gw(9,0,0);
    gw(3,0,2);
    t0=0;
    return 8;
}
private int _8(){
    sa(gr(3,0));

    if(gr(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+3)!=88)return 9;else return 11;
}
private int _9(){
    t0=gr(3,0)+1;
    gw(3,0,gr(3,0)+1);
    t0-=gr(0,0);
    sp();

    if((t0)!=0)return 8;else return 10;
}
private int _10(){
    System.out.print(" =");
    System.out.print(String.valueOf(gr(9,0))+" ");
    return 24;
}
private int _11(){
    gw(5,0,1);
    sa(sr());
    sa(1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()/10L);

    sa(sr());
    return 12;
}
private int _12(){
    if(sp()!=0)return 19;else return 13;
}
private int _13(){
    sp();
    gw(6,0,sp());
    sa(sr());
    gw(7,0,sp());
    return 14;
}
private int _14(){
    sa(sr());
    sa(tm(sr(),gr(1,0)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+3L);

    {long v0=sp();t0=gr(sp(),v0);}
    t0-=32;

    if((t0)!=0)return 15;else return 18;
}
private int _15(){
    t0=sr()/10;
    sa(sp()%10L);

    sa(sp()*gr(6,0));

    sa(t0);
    t0=gr(5,0)-1;
    gw(5,0,gr(5,0)-1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+sp());


    if((t0)!=0)return 14;else return 16;
}
private int _16(){
    System.out.print(String.valueOf(gr(7,0))+" ");
    System.out.print('\n');
    gw(9,0,gr(9,0)+1);
    sa(0);
    return 17;
}
private int _17(){
    sp();
    return 18;
}
private int _18(){
    sp();
    sa(0);
    return 9;
}
private int _19(){
    if((sr()%2)!=0)return 21;else return 20;
}
private int _20(){
    sp();
    return 17;
}
private int _21(){
    if((sr()%5)!=0)return 22;else return 20;
}
private int _22(){
    gw(5,0,gr(5,0)+1);
    sa(sp()/10L);

    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()*10L);

    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr());
    return 12;
}
private int _23(){
    sa(sr());
    sa(32);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),gr(1,0)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+3L);

    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sp()+gr(3,0));

    sa(sr()<gr(0,0)?1:0);
    return 2;
}

public void main(){
    int c=0;
    while(c<24){
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
}
}
}
public static void main(String[]a){new Program().main();}
}
