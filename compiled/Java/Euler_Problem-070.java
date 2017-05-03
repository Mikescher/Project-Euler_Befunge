/* transpiled with BefunCompile v1.1.0 (c) 2015 */
class Program{
private final static String _g = "AR+LCAAAAAAABADtmFFr3DAMgP+KcO5g2KSxlaTJRHD3svc99sHkjh6HYXTMlNZP1/8+eTvYul5LSmm3B33ESizJsizbL8m2AKU1DXy5+f51v7uFz3fX+xuoS//qev8N"+
                                 "Bgvvy263e+cZl3BxcXz+JypBEARBEARBEARBEARBEIQ341//AT2N73t9rsnZ1A+a0Cbd2YStTQo/KO1cUvf8RpcsYnIOuY8ISmvduuSyt+z6M1D2kaUNuXyH2sEEjzVL"+
                                 "ycmOetSaqLQx8VytJQVq0ejNXG2jbaPtJkDIpu9p8sH5jzrQ4YRmca3UpWpt5GLFdWDRtIbTip6boc7GsD06VnmzKlpniMvzp3/kNdQHGMCvA1XzoWo4l7CaYHykeSVz"+
                                 "Mm0TrQtrFhR4XuKY89MD2OpXUAVfcWkqoMpszPy3JueF0+fo3GuX8CutZ1IuSWeozVQvDOapw0QPN+RS1bxf5Iyn/gljh7HHqGlAPolxy5oBI7KGDa7ui9A08v1gVbHO"+
                                 "ebO0Tse8Vjz07NMJS4bFR+G0X/5tfdmZmvka1dEhmYcbWaJMzxkX5Zq4fDgmdBGHl+T1Awao0RSKGwAA";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[7050];for(int i=0;i<7050;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<150&&y<47)?g[(int)(y*150+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<150&&y<47)g[(int)(y*150+x)]=v;}
private java.io.BufferedReader ib=new java.io.BufferedReader(new java.io.InputStreamReader(System.in));
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0,t1,t2;
private int _0(){
    gw(1,0,150);
    gw(2,0,35);
    gw(4,0,5250);
    gw(3,0,2);
    gw(1,1,2000);
    gw(2,1,5000);
    gw(2,2,0);
    gw(1,2,1);
    gw(3,1,10000000);
    return 1;
}
private int _1(){
    gw(0,3,32);
    gw(1,3,32);
    gw(8,0,1073741824);
    gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+3,88);
    sa(gr(3,0)+gr(3,0));
    sa((gr(3,0)+gr(3,0))<gr(4,0)?1:0);
    return 2;
}
private int _2(){
    if(sp()!=0)return 38;else return 3;
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
    if(gr(4,0)>gr(3,0))return 1;else return 7;
}
private int _7(){
    gw(3,0,0);
    sa(gr(1,1));
    gw(4,2,gr(1,1));
    return 8;
}
private int _8(){
    sa(sr());
    sa(tm(sr(),gr(1,0)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+3L);

    {long v0=sp();t0=gr(sp(),v0);}
    t0-=88;

    if((t0)!=0)return 9;else return 12;
}
private int _9(){
    sa(sp()+1L);


    if(sr()!=gr(2,1))return 10;else return 11;
}
private int _10(){
    sa(sr());
    gw(4,2,sp());
    return 8;
}
private int _11()throws java.io.IOException{
    System.out.print(String.valueOf(gr(1,2)));
    sp();
    return 39;
}
private int _12(){
    sa(sr()+1);
    return 13;
}
private int _13(){
    sa(sr());
    gw(5,2,sp());
    sa(sr());
    sa(tm(sr(),gr(1,0)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+3L);

    {long v0=sp();t0=gr(sp(),v0);}
    t0-=88;

    if((t0)!=0)return 16;else return 14;
}
private int _14(){
    t0=gr(4,2)*gr(5,2);
    gw(7,2,gr(4,2)*gr(5,2));
    t0=t0>gr(3,1)?1:0;

    if((t0)!=0)return 17;else return 15;
}
private int _15(){
    t0=gr(7,2)*gr(2,2);
    t1=(gr(4,2)-1)*(gr(5,2)-1);
    gw(8,2,(gr(4,2)-1)*(gr(5,2)-1));
    t1*=gr(1,2);
    t2=t0>t1?1:0;

    if((t2)!=0)return 16;else return 18;
}
private int _16(){
    sa(sp()+1L);


    if(sr()!=gr(2,1))return 13;else return 17;
}
private int _17(){
    sp();
    return 9;
}
private int _18(){
    sa(0);
    sa(tm(gr(7,2),10));
    sa(gr(7,2));
    sa(gr(7,2));
    return 19;
}
private int _19(){
    if(sp()!=0)return 20;else return 24;
}
private int _20(){
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(9);
    return 21;
}
private int _21(){
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr());

    if(sp()!=0)return 23;else return 22;
}
private int _22(){
    sp();
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),10));

    sa(tm(sr(),10));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr());
    return 19;
}
private int _23(){
    sa(sp()-1L);

    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()*9L);
    return 21;
}
private int _24(){
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sp();
    sp();
    return 25;
}
private int _25(){
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr());

    if(sp()!=0)return 26;else return 27;
}
private int _26(){
    sa(sp()+sp());
    return 25;
}
private int _27(){
    sa(sp()+sp());

    sa(0);
    sa(tm(gr(8,2),10));
    sa(gr(8,2));
    sa(gr(8,2));
    return 28;
}
private int _28(){
    if(sp()!=0)return 29;else return 33;
}
private int _29(){
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(9);
    return 30;
}
private int _30(){
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr());

    if(sp()!=0)return 32;else return 31;
}
private int _31(){
    sp();
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),10));

    sa(tm(sr(),10));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr());
    return 28;
}
private int _32(){
    sa(sp()-1L);

    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()*9L);
    return 30;
}
private int _33(){
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sp();
    sp();
    return 34;
}
private int _34(){
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr());

    if(sp()!=0)return 37;else return 35;
}
private int _35(){
    sa(sp()+sp());

    t0=sp();
    sa(sp()-t0);

    t1=sp();

    if((t1)!=0)return 16;else return 36;
}
private int _36(){
    gw(1,2,gr(7,2));
    gw(2,2,gr(8,2));
    return 16;
}
private int _37(){
    sa(sp()+sp());
    return 34;
}
private int _38(){
    sa(sr());
    sa(32);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),gr(1,0)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+3L);

    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sp()+gr(3,0));

    sa(sr()<gr(4,0)?1:0);
    return 2;
}

public void main()throws java.io.IOException{
    int c=0;
    while(c<39){
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
    case 34:c=_34();break;
    case 35:c=_35();break;
    case 36:c=_36();break;
    case 37:c=_37();break;
    case 38:c=_38();break;
}
}
}
public static void main(String[]a){try{new Program().main();}catch(java.io.IOException e){}}
}
