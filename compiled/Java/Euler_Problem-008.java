/* transpiled with BefunCompile v1.1.0 (c) 2015 */
class Program{
private final static String _g = "AR+LCAAAAAAABADtl81uG0cQhF+FYOyLGDv9O90txEIeJFBy45UnPX++kS0gAYw49vKYAYYL7nC3pqurasDzy1nklvHwqFzSHh4eTW4PLrfOS8hNkrmYxWy5nRgvp2Pj"+
                                 "SVOuvPNpyRW06/vf+fhlLteznD88cFMvjyzzow/B/Onlj8eW659c3z3l6yqb8s8rp2Fjp6eSq1w/8tlvj5w/nX/mqY+//RP7+T/u8Vfmu+975Guv+KHx1J853/xQ7+XR"+
                                 "Tl9IOr2xxMpc5LZOb2R9qfr5Rzb79Y2+3X2m9xe9Sv37zw+M797z3Xfw//j7KNdVWitd3WVZjI5Zqs6qCFtZUWGe6XslxuM45qxpTxNXq4qU5bbMJ6tdW5TV4NJrorpT"+
                                 "O/w4ZmcvzSXVo2oUEpORk6LlNdnuOmmdbtItCQHHMdUyhGqgULPTvJeTsXxZ4zYyFA6oQbRLwHF9+53fGmv1rBVNZRFpe9JhitTOFeLCdhQGtIz9uOoduF1mNo00zL2B"+
                                 "aPV0X1ZraVhbywpGs69NQsUcx3Tx7JGyWTCJNulthFQhJBj2VslN+rjULAH7OGYhFgsr2Ov2gcmpET53C8d0tnantoJaxqvugIkBrRxrCgVBKo5QM8GRwS5kKrfK0Fni"+
                                 "FrR0D6+kZQcsIpRVeGGJOuxSMiaK4B7CjVC2ZkoyzB10m76mWmG0OtArxsGhqfAKxcteLaOzF/lm0XYck4KoINQroVmok7QbMVSLaLa0emEhjfRUEYLwDpima3nBJmol"+
                                 "c/CNCIIhB8J3FqLZoMOVjWYX3T6OqWuLtjRqhr6FDabEpstjJTGPX8l23UHBQtDkO2DWq93JeV4cuSASgS6kuggE8kkNDxEPRPKCgrhDP/EmHjTjQNuqNVSqe2wvSlK3"+
                                 "FgRPKCSTCSF9HJOs4bgS7yTOKRSYIPoGl75mbW/OSQ1yEGkNwXEcs+FVCDyURADs1pG7lQGSCDrCnpwCMLzPO852uUM/ZeuRPIhN7sQ+xkDEFbatSSf5P4GQk8AlFjBP"+
                                 "HscspRBbQ6XddFX2YUJ9TRoJCras5OA0Ifg4S3HPccy/AFjBplkkDQAA";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[3364];for(int i=0;i<3364;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<116&&y<29)?g[(int)(y*116+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<116&&y<29)g[(int)(y*116+x)]=v;}
private java.io.BufferedReader ib=new java.io.BufferedReader(new java.io.InputStreamReader(System.in));
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0,t1;
private int _0(){
    gw(0,0,118);
    gw(1,0,20);
    gw(2,0,50);
    gw(3,0,1000);
    gw(4,0,13);
    gw(5,0,0);
    gw(6,0,0);
    gw(7,0,0);
    gw(8,0,0);
    return 1;
}
private int _1(){
    gw(6,0,gr(5,0));
    t0=gr(tm(gr(6,0),gr(2,0)),(td(gr(6,0),gr(2,0)))+9)-48;
    return 2;
}
private int _2(){
    t1=gr(6,0)+1;
    gw(6,0,gr(6,0)+1);
    t1-=gr(5,0);
    t1-=gr(4,0);

    if((t1)!=0)return 3;else return 4;
}
private int _3(){
    t0*=gr(tm(gr(6,0),gr(2,0)),(td(gr(6,0),gr(2,0)))+9)-48;
    return 2;
}
private int _4(){
    if(t0>gr(8,0))return 10;else return 5;
}
private int _5(){
    t0=gr(5,0)+1;
    gw(5,0,gr(5,0)+1);
    t0-=gr(3,0);

    if((t0)!=0)return 1;else return 6;
}
private int _6(){
    gw(7,0,9);
    return 7;
}
private int _7()throws java.io.IOException{
    System.out.print(String.valueOf(gr(gr(7,0),0)));

    if(gr(7,0)-8!=gr(4,0))return 9;else return 8;
}
private int _8()throws java.io.IOException{
    System.out.print('=');
    System.out.print(String.valueOf(gr(8,0)));
    return 13;
}
private int _9(){
    gw(7,0,gr(7,0)+1);
    return 7;
}
private int _10(){
    gw(8,0,t0);
    gw(6,0,0);
    return 11;
}
private int _11(){
    gw(gr(6,0)+9,0,gr(tm(gr(6,0)+gr(5,0),gr(2,0)),(td(gr(6,0)+gr(5,0),gr(2,0)))+9)-48);
    t0=gr(6,0)+1;
    gw(6,0,gr(6,0)+1);
    t0-=gr(4,0);
    return 12;
}
private int _12(){
    if((t0)!=0)return 11;else return 5;
}

public void main()throws java.io.IOException{
    int c=0;
    while(c<13){
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
}
}
}
public static void main(String[]a){try{new Program().main();}catch(java.io.IOException e){}}
}
