/* transpiled with BefunCompile v1.2.0 (c) 2017 */
class Program{
private final static String _g = "AR+LCAAAAAAABADtkM0KwjAQhF+l4i1LZLZV/EGCTxJ722tOOfXh3WCNSBtQ8LhzyWSHfJkkd38V1mQ0oxnNaEYzWpsWvmXlVhDaCSDsGSLFFC/0dCkHBhIzUtCWsj/3"+
                                 "jnTu3VQODWU7buO9EliTd5UEJhZwAryuuNYoalTGpOlHsOjGc5NlFKubNl03Uu8OJypPALe/56W1G287ubjj0C7zgx7G7Dw7OggAAA==";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[2106];for(int i=0;i<2106;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<78&&y<27)?g[(int)(y*78+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<78&&y<27)g[(int)(y*78+x)]=v;}
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
private int _0(){
    gw(0,0,1);
    gw(1,0,1);
    return 1;
}
private int _1(){
    if((gr(0,0)*(22-gr(1,0)))!=0)return 3;else return 2;
}
private int _2(){
    gw(0,0,gr(0,0)+gr(1,0));
    gw(1,0,1);
    return 1;
}
private int _3(){
    if(gr(0,0)>21)return 4;else return 6;
}
private int _4(){
    gw(0,0,gr(0,0)-1);
    gw(1,0,gr(1,0)+1);

    if((gr(1,0)+gr(0,0))<=42)return 1;else return 5;
}
private int _5(){
    System.out.print(String.valueOf(gr(21,21))+" ");
    return 9;
}
private int _6(){
    if(((gr(0,0)-1)*(gr(1,0)-1))!=0)return 8;else return 7;
}
private int _7(){
    gw(gr(0,0),gr(1,0),1);
    return 4;
}
private int _8(){
    gw(gr(0,0),gr(1,0),gr(gr(0,0)-1,gr(1,0))+gr(gr(0,0),gr(1,0)-1));
    return 4;
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
