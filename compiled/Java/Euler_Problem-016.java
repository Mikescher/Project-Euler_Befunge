/* transpiled with BefunCompile v1.2.0 (c) 2017 */
class Program{
private final static String _g = "AR+LCAAAAAAABADtj70OwjAMhF/FBLo0CnVKc6CoqlhZmJhhzOqpE7w7ThH/CCFYuSGRfbY+X8/fq//vfipPP6gjwyZmMQt74Vp4JtwIB6GeqKpotV5tXu6qLWjKhTkY"+
                                 "AZeCOkLgo2kNUdurCecT8LjX3uAZyTtA7ga4I2gfqTh9VdIjnc3N/YmbNRm/C9Y+t6YZ2CDF0Xi7I+8axV74PNdn4A7uGXLWMnOR01i9pbAhRJswL2unpR4IT+oVaRh5"+
                                 "we4uWSQEW2UYrtG375LQEQVMzVNIAwAA";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[840];for(int i=0;i<840;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<60&&y<14)?g[(int)(y*60+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<60&&y<14)g[(int)(y*60+x)]=v;}
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0;
private int _0(){
    gw(0,0,48);
    gw(0,1,48);
    gw(0,2,48);
    gw(0,3,48);
    gw(0,4,48);
    gw(0,5,48);
    gw(1,6,60);
    gw(2,6,6);
    gw(0,6,360);
    gw(4,6,1000);
    return 1;
}
private int _1(){
    t0=gr(4,6);

    if((gr(4,6))==0)return 2;else return 6;
}
private int _2(){
    gw(6,6,gr(0,6)-1);
    t0=gr(tm(gr(6,6),gr(1,6)),td(gr(6,6),gr(1,6)))-48;
    return 3;
}
private int _3(){
    if((gr(6,6))!=0)return 4;else return 5;
}
private int _4(){
    gw(6,6,gr(6,6)-1);
    t0+=gr(tm(gr(6,6),gr(1,6)),td(gr(6,6),gr(1,6)))-48;
    return 3;
}
private int _5(){
    System.out.print(String.valueOf(t0)+" ");
    return 9;
}
private int _6(){
    t0--;
    gw(4,6,t0);
    gw(6,6,gr(0,6)-1);
    gw(7,6,0);
    return 7;
}
private int _7(){
    if((gr(6,6))==0)return 1;else return 8;
}
private int _8(){
    t0=((gr(tm(gr(6,6),gr(1,6)),td(gr(6,6),gr(1,6)))-48)*2)+gr(7,6);
    gw(tm(gr(6,6),gr(1,6)),td(gr(6,6),gr(1,6)),(tm(((gr(tm(gr(6,6),gr(1,6)),td(gr(6,6),gr(1,6)))-48)*2)+gr(7,6),10))+48);
    t0/=10;
    gw(7,6,t0);
    gw(6,6,gr(6,6)-1);
    return 7;
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
