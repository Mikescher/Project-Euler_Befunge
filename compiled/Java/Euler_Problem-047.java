/* transpiled with BefunCompile v1.2.0 (c) 2017 */
class Program{
private final static String _g = "Ah+LCAAAAAAABACT7+ZgAAEWhrc3HLNvG4gwPNj/aOnLpce6Y6x9BQ++2fS7z7rFLEe77aJh8LZ5nx6rt+v5ZlxeumHSpRr5Iye+FSct+a5ivf3mqYwptbt+/vz76vX6"+
                                 "N4/fv149e82L7/tj4v+eeOXJtiHdnWGogwObUw+EnX1we8G5TZMj2vLm3FL/aFKirliyPPQF202FtlXaq9+V3X66kC/WY6FvcOu2M8lZy9Zn9adnGq/6VPahMkDmbtyy"+
                                 "yaUZyTOvz36+W+BWSd48p21/jyTe3Ci+rF9+3x6LWdsXZjnPiLP5/+rshA235+4p9PV6sOr8na1zfH/XbntuqPo+p058hlHFjrVsmxw3VqRVlVeaZjlbWvvNjpiSu6Jc"+
                                 "Ysvh0o0X4zfXPfL6+9WF12f2pk7FZS8z5qitj8jnK6yuEZ/mVvp3iuUr1qerrz26W3NtHX+G+KsZ310FlsdKfF/7cQV/gLD+iritsx5arL3/10ru3OU7Yslz57fmCe1a"+
                                 "lfFIZcvRTQHnpk+O54pwCzv6+2H737t/pL8UmFWr/BV3lT4XtNbnv+TJ+u8FLW2r+7bf2qP13dl06609et9Xny1y9eQ+tS7fdU+D6y+RUulz1/tWtvzN/GcXaXq6faPn"+
                                 "f75dN777yvYs/xe2s3zH14/sevJ84QmazAwAB/3uX5ICAAA=";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[207200];for(int i=0;i<207200;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<400&&y<518)?g[(int)(y*400+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<400&&y<518)g[(int)(y*400+x)]=v;}
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0,t1;
private int _0(){
    gw(1,0,400);
    gw(2,0,500);
    gw(0,0,200000);
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
    if(sp()!=0)return 33;else return 3;
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
    if(gr(0,0)>gr(3,0))return 1;else return 7;
}
private int _7(){
    gw(4,0,0);
    gw(3,0,0);
    return 8;
}
private int _8(){
    sa(gr(3,0)+1);
    gw(3,0,gr(3,0)+1);
    sa(tm(sr(),gr(1,0)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+3L);

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
    gw(4,0,gr(4,0)+1);
    sa(tm(sr(),gr(1,0)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+3L);

    {long v0=sp();long v1=sp();gw(v1,v0,sp());}

    if(gr(0,0)>gr(3,0))return 8;else return 11;
}
private int _11(){
    gw(tm(gr(4,0)-1,gr(1,0)),(td(gr(4,0)-1,gr(1,0)))+3,0);
    gw(4,0,0);
    gw(5,0,0);
    sa(1);
    sa(1);
    sa(tm(1,gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+3)));
    return 12;
}
private int _12(){
    if(sp()!=0)return 13;else return 32;
}
private int _13(){
    sa(sr());
    sa(gr(4,0)+1);
    gw(4,0,gr(4,0)+1);
    sa(tm(sr(),gr(1,0)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+3L);

    {long v0=sp();t0=gr(sp(),v0);}
    sa((sp()<t0)?1:0);

    t1=sp();
    t1=(t1!=0)?0:1;

    if((t1)!=0)return 31;else return 14;
}
private int _14(){
    sp();

    if(gr(5,0)!=4)return 30;else return 15;
}
private int _15(){
    gw(8,0,0);
    sa(sr());
    sa(sr());
    t0=sr()+4;
    gw(6,0,t0);
    gw(7,0,sp());
    sa(sp()-3L);
    return 16;
}
private int _16(){
    if(sr()!=gr(7,0))return 22;else return 17;
}
private int _17(){
    t0=gr(8,0)+1;
    gw(8,0,gr(8,0)+1);
    t0-=4;

    if((t0)!=0)return 18;else return 21;
}
private int _18(){
    sa(sp()+1L);


    if(sr()!=gr(6,0))return 16;else return 19;
}
private int _19(){
    gw(4,0,0);
    gw(5,0,0);
    sp();
    return 20;
}
private int _20(){
    sa(sp()+4L);

    sa(sr());
    sa(tm(sr(),gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+3)));
    return 12;
}
private int _21(){
    sa(sp()-3L);

    System.out.print(String.valueOf((long)(sp()))+" ");
    sp();
    return 34;
}
private int _22(){
    gw(4,0,0);
    gw(5,0,0);
    sa(sr());
    return 23;
}
private int _23(){
    if(tm(sr(),gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+3))!=0)return 24;else return 29;
}
private int _24(){
    sa(sr());
    sa(gr(4,0)+1);
    gw(4,0,gr(4,0)+1);
    sa(tm(sr(),gr(1,0)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+3L);

    {long v0=sp();t0=gr(sp(),v0);}
    sa((sp()<t0)?1:0);

    t1=sp();
    t1=(t1!=0)?0:1;

    if((t1)!=0)return 23;else return 25;
}
private int _25(){
    sp();

    if(gr(5,0)!=4)return 26;else return 28;
}
private int _26(){
    gw(8,0,0);

    if(sr()<gr(7,0))return 27;else return 19;
}
private int _27(){
    if(gr(8,0)!=4)return 18;else return 21;
}
private int _28(){
    gw(8,0,gr(8,0)+1);
    return 27;
}
private int _29(){
    t0=gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+3);
    gw(5,0,gr(5,0)+1);
    sa(td(sp(),t0));
    return 24;
}
private int _30(){
    gw(4,0,0);
    gw(5,0,0);
    return 20;
}
private int _31(){
    sa(tm(sr(),gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+3)));
    return 12;
}
private int _32(){
    t0=gr(tm(gr(4,0),gr(1,0)),(td(gr(4,0),gr(1,0)))+3);
    gw(5,0,gr(5,0)+1);
    sa(td(sp(),t0));
    return 13;
}
private int _33(){
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
    while(c<34){
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
    case 32:c=_32();break;
    case 33:c=_33();break;
}
}
}
public static void main(String[]a){new Program().main();}
}
