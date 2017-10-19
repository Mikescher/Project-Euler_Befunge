/* transpiled with BefunCompile v1.3.0 (c) 2017 */
class Program{
private final static String _g = "Ah+LCAAAAAAABACT7+ZgAAEWhre3DuZddhBguBBfKPt9ksnZXWpdSVNFxd/JVG+YxLVCZ6HSGq6aV8c36/Gqdjg4tK54ZHvy2jrjbPXlJ9csP79v1tlN4eby92L3/pyx"+
                                 "909Jbelk3/afr1+v/h659QTY+Ia5bgyjYBSMgiEPDtRrMzPM2zNj/9n5Z48/3sVz16b3+NfIF8cUS9JDX3zSWe98dWrodf6NtRFnVm/eEHmrNdXC/o45O4PZr7+Hyp68"+
                                 "/ZpVcrNtFa+QNYNMwBn9T1pbVtrk988umRU6We9sspVaKUducaW8xavrRwu2zrmysui/2T7f1D9fvk2wZ2LoOH3h2fnNf548+XL02a1Vs0M2m005W2h19eyGj/O0Plx9"+
                                 "N3vFecYHBd/u5O//3F+0bT8bw4fj24yq71z9Mc9O419QcI39qWVLU/gY+pd5uN/ZX9bv+tngZvbNSrHXv0rs5s/RcbaObHtXbsbF0KC70U7q62vXF9MMV4sv9JUsq7nP"+
                                 "UT7b6F3Y7duudrJrr5XOTZp1ekuWxJlTancTt8q1nd2w42X9ljXx5l9tSo5/3q1+ZtYvs7rrjuKzI6Yf/ts9f89SdoayzqPTy3aEaOZbPWqb86t77fsImx731YurjP88"+
                                 "3BQh8jCx6HvLDlnFbuYDkzdpdR+qLmKosJnPeCvsc9KC9fwMAD1IlPqhBQAA";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[1028000];for(int i=0;i<1028000;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<2000&&y<514)?g[(int)(y*2000+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<2000&&y<514)g[(int)(y*2000+x)]=v;}
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
    if(sp()!=0)return 29;else return 3;
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
    t0=0;
    sa(0);
    sa(2);
    sa(3);
    sa(5);
    sa(7);
    sa(7);
    return 8;
}
private int _8(){
    if(sp()!=0)return 10;else return 9;
}
private int _9(){
    System.out.print(" =");
    System.out.print(String.valueOf(gr(9,0))+" ");
    sp();
    return 30;
}
private int _10(){
    gw(7,0,sp());
    sa(9);
    sa(9+(gr(7,0)*10));
    sa((9+(gr(7,0)*10))<gr(0,0)?1:0);
    return 11;
}
private int _11(){
    if(sp()!=0)return 12;else return 28;
}
private int _12(){
    sa(sr());
    sa(tm(sr(),gr(1,0)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+3L);

    {long v0=sp();t0=gr(sp(),v0);}
    t0-=88;

    if((t0)!=0)return 27;else return 13;
}
private int _13(){
    sa(sr());

    if(sr()<10)return 14;else return 20;
}
private int _14(){
    sp();
    sa((sp()!=0)?0:1);
    sa(sr());
    return 15;
}
private int _15(){
    sp();
    sp();
    return 16;
}
private int _16(){
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    return 17;
}
private int _17(){
    if(sr()!=1)return 19;else return 18;
}
private int _18(){
    sp();
    sa(sr());
    return 8;
}
private int _19(){
    sa(sp()-1L);

    sa(sr()+(gr(7,0)*10));
    sa(sr()<gr(0,0)?1:0);
    return 11;
}
private int _20(){
    sa(sr()/10);
    sa(1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr());
    return 21;
}
private int _21(){
    if(sp()!=0)return 22;else return 23;
}
private int _22(){
    sa(sp()/10L);

    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()*10L);

    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr());
    return 21;
}
private int _23(){
    sp();
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    return 24;
}
private int _24(){
    sa(sr());
    sa(tm(sr(),gr(1,0)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(1,0)));

    sa(sp()+3L);

    {long v0=sp();t0=gr(sp(),v0);}
    t0-=88;

    if((t0)!=0)return 15;else return 25;
}
private int _25(){
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr());
    gw(5,0,sp());
    {long v0=sp();sa(tm(sp(),v0));}

    sa(gr(5,0)/10);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr());

    if(sp()!=0)return 24;else return 26;
}
private int _26(){
    sp();
    sp();
    sa(sr());
    sa(sr());
    System.out.print(String.valueOf((long)(sp()))+" ");
    System.out.print('\n');
    sa(sp()+gr(9,0));

    gw(9,0,sp());
    return 16;
}
private int _27(){
    sp();
    return 17;
}
private int _28(){
    t0=0;
    return 27;
}
private int _29(){
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
    while(c<30){
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
}
}
}
public static void main(String[]a){new Program().main();}
}
