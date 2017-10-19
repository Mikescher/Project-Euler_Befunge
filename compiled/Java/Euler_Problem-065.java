/* transpiled with BefunCompile v1.3.0 (c) 2017 */
class Program{
private final static String _g = "AR+LCAAAAAAABADNUjFuwzAM/ApLKUsIJRTtDBEMolNXfyBwhg5aNXny40s3TlI0bge1BXqDcKQE8njiCN57MLjfAfwV/rG+8SETYldZS/EFNR0JGU9cFiIlTbXa8BUL"+
                                 "t1wE+2gMe0ZL+1p9H5T6eO/yvOtGlmBiC2duUhY75zBzKhZ3XzuiKYZmk56mC6dmL1tzlDRvqeVM6XCgjVWihrMUC/btbExYd0RvTqkEN5zjwhnKenvs0brZXvjV6wnU"+
                                 "gSNwEVwCF4yIg+HbPdL3B+vzfu6ip3E+LuNXQHlZGMnmUbDp1WpFoJ988HAlIZ5tlOplNrwBk9ih3GAEAAA=";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[1120];for(int i=0;i<1120;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<80&&y<14)?g[(int)(y*80+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<80&&y<14)g[(int)(y*80+x)]=v;}
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0,t1;
private int _0(){
    gw(79,0,48);
    gw(79,2,48);
    sa(70);
    sa(70);
    return 1;
}
private int _1(){
    if(sp()!=0)return 24;else return 2;
}
private int _2(){
    gw(79,0,48);
    gw(79,2,49);
    gw(4,0,0);
    sp();
    sa(99);
    sa(99);
    return 3;
}
private int _3(){
    if(sp()!=0)return 4;else return 23;
}
private int _4(){
    sa((sr()-1)%3);
    sa(sr());

    if(sp()!=0)return 5;else return 22;
}
private int _5(){
    sa(sp()-2L);


    if(sp()!=0)return 21;else return 6;
}
private int _6(){
    gw(2,0,1);
    return 7;
}
private int _7(){
    gw(3,0,79);
    sa(79);
    sa(gr(79,0)-48);
    return 8;
}
private int _8(){
    t0=gr(gr(3,0),2)-48;
    gw(gr(3,0),0,gr(gr(3,0),2));
    t0*=gr(2,0);
    sa(sp()+t0);

    t1=sp();
    t1+=gr(4,0);
    gw(gr(3,0),2,(t1%10)+48);
    t1/=10;
    gw(4,0,t1);

    if(sr()!=9)return 20;else return 9;
}
private int _9(){
    sp();
    sa(sp()-1L);


    if(sr()!=-1)return 19;else return 10;
}
private int _10(){
    sp();
    sa(0);
    sa(70);
    sa(gr(79,2)-48);
    sa(gr(79,2)-48);
    return 11;
}
private int _11(){
    if(sp()!=0)return 12;else return 18;
}
private int _12(){
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    return 13;
}
private int _13(){
    sa(sr());

    if(sp()!=0)return 17;else return 14;
}
private int _14(){
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr());

    if(sp()!=0)return 15;else return 16;
}
private int _15(){
    sa(sp()+sp());
    return 14;
}
private int _16(){
    sa(sp()+sp());

    t0=sp();
    System.out.print(String.valueOf(t0)+" ");
    return 25;
}
private int _17(){
    sa(sp()-1L);

    sa(gr(sr()+9,2)-48);
    sa(sr());
    return 11;
}
private int _18(){
    if(sp()!=0)return 17;else return 13;
}
private int _19(){
    sa(sr());
    return 3;
}
private int _20(){
    sa(sp()-1L);

    sa(sr());
    gw(3,0,sp());
    sa(sr());
    sa(0);
    {long v0=sp();sa(gr(sp(),v0));}
    sa(sp()-48L);
    return 8;
}
private int _21(){
    gw(2,0,((sr()+1)/3)*2);
    return 7;
}
private int _22(){
    gw(2,0,1);
    sp();
    return 7;
}
private int _23(){
    gw(2,0,2);
    return 7;
}
private int _24(){
    sa(sp()-1L);

    sa(sr()+9);
    sa(48);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(0);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr()+9);
    sa(48);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(2);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr());
    return 1;
}

public void main(){
    int c=0;
    while(c<25){
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
}
}
}
public static void main(String[]a){new Program().main();}
}
