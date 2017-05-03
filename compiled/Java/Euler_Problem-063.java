/* transpiled with BefunCompile v1.1.0 (c) 2015 */
class Program{
private final static String _g = "AR+LCAAAAAAABAC9jrFOxDAQRH9lsUODZdh1YomsrBV/ACWFlaNzu5WrfPzt5XQ6BFKUAjHVeLTzPB0+TQDg/0YAG+0f1KmSUmIOZK8aWioHWvibMyuOit/atRk2UFlS"+
                                 "1ZROfY9HdyvXwx/nhu2xug934/Owx5Ob4U5dUGUWdugqKgV27y6uwtgsiev68GVDS9zl3cVaxw6KGRUnIxXF6siVJYgnGHwBTtTiWp+P8RKRCkzYrnMSYHvK2ALnHB4t"+
                                 "6TKYwx7ejvFkSbjGVxvHkRpOl6kvIYPPan9MoUj2Q/ZlOYbbiDJio8gjKvjlNG/p8f5FZx340XggAwAA";
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
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0,t1;
private int _0(){
    gw(2,1,1);
    gw(2,0,1);
    gw(3,0,1);
    gw(9,0,48);
    sa(0);
    sa(1);
    sa(1);
    sa(10);
    return 1;
}
private int _1(){
    sa(sr());
    sa(48);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(0);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sp()+1L);
    return 2;
}
private int _2(){
    if(sr()!=79)return 1;else return 3;
}
private int _3(){
    sa(49);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(0);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    return 4;
}
private int _4(){
    gw(4,0,79);
    gw(5,0,0);
    return 5;
}
private int _5(){
    t0=((gr(gr(4,0),0)-48)*gr(2,0))+gr(5,0);
    gw(gr(4,0),0,(tm(((gr(gr(4,0),0)-48)*gr(2,0))+gr(5,0),10))+48);
    t0/=10;
    gw(5,0,t0);
    t0=gr(4,0)-1;
    gw(4,0,gr(4,0)-1);
    t0-=8;
    return 6;
}
private int _6(){
    if((t0)!=0)return 5;else return 7;
}
private int _7(){
    t0=gr(3,0)-1;
    gw(3,0,gr(3,0)-1);

    if((t0)!=0)return 4;else return 8;
}
private int _8(){
    sa(9);
    sa(gr(9,0)-48);
    return 9;
}
private int _9(){
    if(sp()!=0)return 10;else return 18;
}
private int _10(){
    t0=80;
    sa(t0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    {long v0=sp();sa(sp()-v0);}

    t1=sp();

    if(t1!=gr(2,1))return 11;else return 16;
}
private int _11(){
    t1=t1>gr(2,1)?1:0;
    t1=(t1!=0)?0:1;

    if((t1)!=0)return 14;else return 12;
}
private int _12(){
    sp();
    sa(0);
    return 13;
}
private int _13(){
    sp();
    sp();
    System.out.print(String.valueOf((long)(sp())));
    return 19;
}
private int _14(){
    sa(sp()+1L);

    sa(sr());
    sa(gr(2,1));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    gw(2,0,sp());
    return 15;
}
private int _15(){
    gw(3,0,sp());
    gw(9,0,48);
    sa(10);
    return 1;
}
private int _16(){
    t0=10;
    sa(t0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    {long v0=sp();sa(sp()-v0);}

    sa(sr());

    if(sp()!=0)return 17;else return 13;
}
private int _17(){
    gw(2,2,sp());
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+gr(2,2));

    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+1L);

    sa(sr());
    sa(sr());
    gw(2,1,sp());
    gw(2,0,1);
    sa(1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    return 15;
}
private int _18(){
    sa(sp()+1L);

    sa(sr());
    sa(0);
    {long v0=sp();sa(gr(sp(),v0));}
    sa(sp()-48L);
    return 9;
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
