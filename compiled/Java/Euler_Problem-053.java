/* transpiled with BefunCompile v1.1.0 (c) 2015 */
class Program{
private final static String _g = "AR+LCAAAAAAABACtUE0PwiAM/St0nRcIWhgHtxDiL2EeTLhy4qT/3fqBmy7zYHxJQ9PXPl5bBCIKBv4A8QV/0gump2x6k8ny21EuyxZHqVcdJbuBxPm+5qoUSLCxiTrV"+
                                 "J3JHKX1gbmhOjQYso1EDK9qdo3yr86yVQZ9XdwrD9FVuLpdDE+OMRd8K9JbS9vDp7+XJyhkTQ3sXNPrJwnK7h0R1J3RcaZkwFoQa/o2pZseIkMkN2vBVfJ4uRHxmpQyA"+
                                 "llxzXE5kWxapIa6IhbYwMAIAAA==";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[560];for(int i=0;i<560;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<80&&y<7)?g[(int)(y*80+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<80&&y<7)g[(int)(y*80+x)]=v;}
private java.io.BufferedReader ib=new java.io.BufferedReader(new java.io.InputStreamReader(System.in));
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0;
private int _0(){
    gw(9,0,1);
    gw(9,1,1);
    gw(2,0,0);
    gw(3,0,1);
    return 1;
}
private int _1(){
    sa(gr(3,0));

    if(gr(3,0)-100==0)return 2;else return 3;
}
private int _2()throws java.io.IOException{
    System.out.print(String.valueOf(gr(2,0)));
    sp();
    return 16;
}
private int _3(){
    sa(sp()+1L);

    sa(sr());
    gw(3,0,sp());
    sa(td(sp(),2));

    gw(4,0,sp());
    sa(gr(3,0)-(gr(4,0)*2));
    return 4;
}
private int _4(){
    if(sp()!=0)return 15;else return 5;
}
private int _5(){
    sa(gr(gr(4,0)+8,(tm(gr(3,0),2)!=0)?0:1)*2);
    gw(gr(4,0)+9,tm(gr(3,0),2),gr(gr(4,0)+8,(tm(gr(3,0),2)!=0)?0:1)*2);
    return 6;
}
private int _6(){
    sa((sp()>1000000)?1:0);

    t0=((gr(gr(4,0)+9,(tm(gr(3,0),2)!=0)?0:1))!=0)?0:1;

    if((((gr(gr(4,0)+8,(tm(gr(3,0),2)!=0)?0:1))!=0)?1:0)!=0)return 7;else return 13;
}
private int _7(){
    t0=(t0!=0)?0:1;

    if((t0)!=0)return 8;else return 13;
}
private int _8(){
    sa((sp()!=0)?0:1);

    if(sp()!=0)return 9;else return 11;
}
private int _9(){
    t0=gr(4,0)-1;
    gw(4,0,gr(4,0)-1);
    t0=(t0!=0)?0:1;

    if((t0)!=0)return 1;else return 10;
}
private int _10(){
    sa(sp()-(gr(3,0)-(gr(4,0)*2)));
    return 4;
}
private int _11(){
    gw(2,0,gr(2,0)+((gr(3,0)-(gr(4,0)*2)!=0)?1:0)+1L);
    gw(gr(4,0)+9,tm(gr(3,0),2),0);
    return 12;
}
private int _12(){
    sp();
    return 9;
}
private int _13(){
    gw(2,0,gr(2,0)+((gr(3,0)-(gr(4,0)*2)!=0)?1:0)+1L);
    gw(gr(4,0)+9,tm(gr(3,0),2),0);
    return 14;
}
private int _14(){
    sp();
    return 12;
}
private int _15(){
    sa(gr(gr(4,0)+9,(tm(gr(3,0),2)!=0)?0:1)+gr(gr(4,0)+8,(tm(gr(3,0),2)!=0)?0:1));
    gw(gr(4,0)+9,tm(gr(3,0),2),gr(gr(4,0)+9,(tm(gr(3,0),2)!=0)?0:1)+gr(gr(4,0)+8,(tm(gr(3,0),2)!=0)?0:1));
    return 6;
}

public void main()throws java.io.IOException{
    int c=0;
    while(c<16){
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
}
}
}
public static void main(String[]a){try{new Program().main();}catch(java.io.IOException e){}}
}
