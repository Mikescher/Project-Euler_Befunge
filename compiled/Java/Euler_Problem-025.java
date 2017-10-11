/* transpiled with BefunCompile v1.2.0 (c) 2017 */
class Program{
private final static String _g = "AR+LCAAAAAAABADtkc8KgzAMxl9FCl4Mzq9qVxCRPYmnQa49efLhF5ljRdmYjv055Lsk/dL0l7ZD8jths/a0KFrRila0ohWtaEUr+iNou6flz9Q5d/RZlgHBlMYiJGWF"+
                                 "0A3fQG+yp//hGgFOxqvBNpfFFMGpqQ1d08ISG5i8mSt24TswUTIkQ7s4fGU80MioA9mCYSUjm86JHB7ZMlBUSMk5mbuQ0LR9O+aZZOZscoZnQAzZxLduf+/2bYCXK1ck"+
                                 "i+rFCZ+pq8CHU2x4eR4Sxmpr/z4t0gVqKcfndA0AAA==";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[3444];for(int i=0;i<3444;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<123&&y<28)?g[(int)(y*123+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<123&&y<28)g[(int)(y*123+x)]=v;}
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0,t1;
private int _0(){
    gw(0,0,1050);
    gw(1,0,50);
    gw(3,0,2);
    return 1;
}
private int _1(){
    gw(4,0,gr(0,0));
    gw(5,0,0);
    return 2;
}
private int _2(){
    gw(4,0,gr(4,0)-1);
    t0=gr((tm(gr(4,0),gr(1,0)))+52,(td(gr(4,0),gr(1,0)))+1)-48;
    t1=(gr((tm(gr(4,0),gr(1,0)))+52,(td(gr(4,0),gr(1,0)))+1)-48)+(gr((tm(gr(4,0),gr(1,0)))+1,(td(gr(4,0),gr(1,0)))+1)-48)+gr(5,0);
    gw(5,0,td((gr((tm(gr(4,0),gr(1,0)))+52,(td(gr(4,0),gr(1,0)))+1)-48)+(gr((tm(gr(4,0),gr(1,0)))+1,(td(gr(4,0),gr(1,0)))+1)-48)+gr(5,0),10));
    t1%=10;
    t1+=48;
    gw((tm(gr(4,0),gr(1,0)))+52,(td(gr(4,0),gr(1,0)))+1,t1);
    t0+=48;
    gw((tm(gr(4,0),gr(1,0)))+1,(td(gr(4,0),gr(1,0)))+1,t0);
    return 3;
}
private int _3(){
    if((gr(4,0))!=0)return 2;else return 4;
}
private int _4(){
    gw(3,0,gr(3,0)+1);
    gw(7,0,0);
    return 5;
}
private int _5(){
    if(gr((tm(gr(7,0),gr(1,0)))+52,(td(gr(7,0),gr(1,0)))+1)!=48)return 7;else return 6;
}
private int _6(){
    gw(7,0,gr(7,0)+1);
    return 5;
}
private int _7(){
    if(gr(0,0)-gr(7,0)!=1000)return 1;else return 8;
}
private int _8(){
    System.out.print(String.valueOf(gr(3,0))+" ");
    return 9;
}

public void main(){
    int c=0;
    while(c<9){
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
}
}
}
public static void main(String[]a){new Program().main();}
}
