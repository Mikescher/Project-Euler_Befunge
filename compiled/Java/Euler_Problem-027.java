/* transpiled with BefunCompile v1.1.0 (c) 2015 */
class Program{
private final static String _g = "Ah+LCAAAAAAABACT7+ZgAAEWhrc3HLsvO4gwPNg/ybdMn3Pr5JTbtzaw6N+zrdLIDTzdsEZC7O1J+fchYbp5u7vWeJTv57eacOaM9tJ+c/2badaPC7+9evb499nb/jdP"+
                                 "n78+e3bOlt11xXt/Trjqy8bQH8rIQBPwwSP1A/+Xn7trospKJW7tOXl6HaezJb/z5bZEo5k2+qc/GfEsXNv+duLbyHutZStuK3NXzPpnIb2O726MbncpTy7P58OfbUJr"+
                                 "/1nlO/uwasfpXDLIW60Y+/1lcOlnAfHXt1uPlpXu2x0dHrsq9ffr5FWRi9+c/v9HdE7H04CtjyVeHXWV2nX03RZv1szK83xfu2z5r4t66tQ9ztv01XXb349vLFoiw68a"+
                                 "nqlbFjTf6renlcrrRKmk4jWn7eXqz+u96E5PXTNbxG/TvBV2MW0Wq1Z7VrHNaVvIf1enN3bmpBSxpJmblqzaVTV31/J/fv6hOuGZvtevFf7NLr+6/K/v1aUrNP/80jFN"+
                                 "/33/iv/+r5mXmWtvRXLNStv/ftf7J09LZH7LB++14mefJl79+ejCzujw+q+LfLZaRcYzHtq6S3BDNSMDABHvrYXvAQAA";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[97200];for(int i=0;i<97200;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<600&&y<162)?g[(int)(y*600+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<600&&y<162)g[(int)(y*600+x)]=v;}
private java.io.BufferedReader ib=new java.io.BufferedReader(new java.io.InputStreamReader(System.in));
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0;
private int _0(){
    gw(1,0,600);
    gw(2,0,150);
    gw(9,0,90000);
    gw(3,0,2);
    gw(4,0,1000);
    gw(3,1,0);
    return 1;
}
private int _1(){
    gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+3,88);
    sa(gr(3,0)+gr(3,0));
    sa((gr(3,0)+gr(3,0))<gr(9,0)?1:0);
    return 2;
}
private int _2(){
    if(sp()!=0)return 21;else return 3;
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

    sa(sp()+3L);

    {long v0=sp();t0=gr(sp(),v0);}
    t0-=32;
    return 5;
}
private int _5(){
    if((t0)!=0)return 6;else return 4;
}
private int _6(){
    if(gr(9,0)>gr(3,0))return 1;else return 7;
}
private int _7(){
    gw(0,3,32);
    gw(1,3,32);
    gw(5,0,1-gr(4,0));
    gw(6,0,2);
    return 8;
}
private int _8(){
    gw(7,0,0);
    sa((gr(5,0)*gr(7,0))+gr(6,0));
    sa(((gr(5,0)*gr(7,0))+gr(6,0))>1?1:0);
    return 9;
}
private int _9(){
    if(sp()!=0)return 10;else return 20;
}
private int _10(){
    sa(tm(sr(),gr(1,0)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+3L);

    {long v0=sp();t0=gr(sp(),v0);}
    t0-=32;

    if((t0)!=0)return 19;else return 11;
}
private int _11(){
    t0=gr(7,0);

    if(gr(7,0)>gr(3,1))return 18;else return 12;
}
private int _12(){
    t0=gr(5,0)+2;
    gw(5,0,gr(5,0)+2);
    t0=t0>gr(4,0)?1:0;
    t0=(t0!=0)?0:1;

    if((t0)!=0)return 8;else return 13;
}
private int _13(){
    gw(5,0,1-gr(4,0));
    return 14;
}
private int _14(){
    sa(gr(6,0)+1);
    gw(6,0,gr(6,0)+1);
    sa(tm(sr(),gr(1,0)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+3L);

    {long v0=sp();t0=gr(sp(),v0);}
    t0-=32;
    t0=(t0!=0)?0:1;
    return 15;
}
private int _15(){
    if((t0)!=0)return 14;else return 16;
}
private int _16(){
    if(gr(6,0)<=gr(4,0))return 8;else return 17;
}
private int _17()throws java.io.IOException{
    System.out.print(String.valueOf(gr(1,1)*gr(2,1)));
    return 22;
}
private int _18(){
    gw(3,1,t0);
    gw(1,1,gr(5,0));
    gw(2,1,gr(6,0));
    return 12;
}
private int _19(){
    sa(gr(7,0)+1);
    gw(7,0,gr(7,0)+1);
    sa(sr());
    sa(sp()*sp());

    sa(sp()+(gr(5,0)*gr(7,0))+gr(6,0));

    sa(sr()>1?1:0);
    return 9;
}
private int _20(){
    sp();
    return 11;
}
private int _21(){
    sa(sr());
    sa(32);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),gr(1,0)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+3L);

    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sp()+gr(3,0));

    sa(sr()<gr(9,0)?1:0);
    return 2;
}

public void main()throws java.io.IOException{
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
public static void main(String[]a){try{new Program().main();}catch(java.io.IOException e){}}
}
