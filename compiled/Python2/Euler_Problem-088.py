#!/usr/bin/env python2

# transpiled with BefunCompile v1.3.0 (c) 2017
import sys
import zlib, base64
_g = ("AR+LCAAAAAAABADt28tSpDAUgOFXiYIbUow5BBRTVGreYLazoGh22WbFaubdJ9Ci7aV1yrlg6/91VYtJ7IqLJOccmkl9TxSAT+lbsvUcAADA/5QBAAAAAAAAAAAAAAAA"
  + "AAAAAIB3b+vnDwBsZ+v9BwAAAAAAAAAAAAAAAAAAAAAAvG7r5w8AnIYp6la3l8E0/UV6c724qO1lt/W8ALyNPx9Hda6LysTzn+N5YU1sXbF/1SZWbTG/mnRlgndn2bST"
  + "0tUm9K4x4aJPb2rY+n8A8EZTlLqKYrUEY6NUVTrkW6mOjM67yZVlkDqITePTBac/cLqm413PLu1HFYPdkJVW63HeElIucJcbzJvE8a2hiw/GsocA2/BWgmgrUZm2KoJz"
  + "tYT+shdd1Eqi6Lk1mib1K5+60mhrQiWh1GNKBtJ1akntZSnjvns8u21UQ2q9SxMurZ7HjVrbMht29fI5t39LBgG8O8N6Sq8N82l9eFZ71Ui4X+Fpp9Bhv3/UEu0LkQWA"
  + "dyHl/03K/aWZawB9Suuj1EX6Wbugi+qg2h9ENfFxU/No0PpJZf9S+A/gffDNEomLLlM4/7Dr8QH+SpjOegdOTVrk++q/WBYw8Mn4Z1J4J/pJa1RrYi86XRXpIo2pJIxr"
  + "3EAVDzgxU7RiojXmmb7fjQf8shFE1j9w6rzV4Wq+JXh45y5eLeGAmtMFn+dU9oEPw0uc/LWEUqlsUtPTZ4IOAoHUme+mbOyDtNQLgNN3PZlucMvX97qUxR/e37taWtX9"
  + "7T0X5cp1yrdpu/ix9cQB/BFvpBy8W4P9QU273Jn16R61j/4PBizf43NuWfr51pMH8OeGFNGXwVTpfO+8u97X9FuJzkvpRCt1f9Jnc5k/z5fQXzabMIC/6O4ovy3i5z5T"
  + "19m8xGOmurwzSj14ZKdPDZr8Hzh9kzFHlvL6BMD6e3/Bmgc+lkkfjeRZ7sAH5527kXhY4NM3Epw1lPiBz8znX/KvW08CwL/xC0UCinQAyAAA")
g = base64.b64decode(_g)[1:]
for i in range(ord(base64.b64decode(_g)[0])):
    g = zlib.decompress(g, 16+zlib.MAX_WBITS)
g=list(map(ord, g))
def gr(x,y):
    if(x>=0 and y>=0 and x<1024 and y<50):
        return g[y*1024 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<1024 and y<50):
        g[y*1024 + x]=v;
def td(a,b):
    return ((0)if(b==0)else(a//b))
def tm(a,b):
    return ((0)if(b==0)else(a%b))
s=[]
def sp():
    global s
    if (len(s) == 0):
        return 0
    return s.pop()
def sa(v):
    global s
    s.append(v)
def sr():
    global s
    if (len(s) == 0):
        return 0
    return s[-1]
def _0():
    gw(2,0,12288)
    gw(3,0,12000)
    gw(4,0,281474976710656)
    gw(5,0,1024)
    sa(gr(2,0))
    sa(gr(2,0))
    return 1
def _1():
    return (32)if(sp()!=0)else(2)
def _2():
    gw(1,16,2)
    gw(2,1,2)
    gw(3,1,gr(3,0)+1)
    gw(4,1,2)
    sp();
    return 3
def _3():
    global t0
    gw(3,1,gr(3,1)+1)
    t0=gr(0,16)+1
    gw(4,1,(td(gr(4,1),gr(0,16)))*(gr(0,16)+1))
    gw(0,16,t0)
    gw(5,1,0)
    return 4
def _4():
    return (5)if(gr(4,1)>(gr(3,1)+(gr(3,0)-gr(2,1))))else(30)
def _5():
    global t0
    global t1
    global t2
    t0=gr(tm(gr(5,1),gr(5,0)),(td(gr(5,1),gr(5,0)))+16)
    gw(4,1,td(gr(4,1),gr(tm(gr(5,1),gr(5,0)),(td(gr(5,1),gr(5,0)))+16)))
    t1=gr(3,1)
    t2=t1-t0
    gw(3,1,t2)
    gw(tm(gr(5,1),gr(5,0)),(td(gr(5,1),gr(5,0)))+16,gr(tm(gr(5,1)+1,gr(5,0)),(td(gr(5,1)+1,gr(5,0)))+16))
    t0=gr(tm(gr(5,1),gr(5,0)),(td(gr(5,1),gr(5,0)))+16)
    gw(4,1,gr(4,1)*gr(tm(gr(5,1),gr(5,0)),(td(gr(5,1),gr(5,0)))+16))
    t1=gr(3,1)
    t2=t1+t0
    gw(3,1,t2)
    gw(5,1,gr(5,1)+1)

    return (6)if((gr(5,1)-(gr(3,0)+1))!=0)else(8)
def _6():
    global t0
    global t1
    global t2
    global t3
    gw(3,1,gr(3,1)+1)
    t0=gr(tm(gr(5,1),gr(5,0)),(td(gr(5,1),gr(5,0)))+16)
    t1=gr(tm(gr(5,1),gr(5,0)),(td(gr(5,1),gr(5,0)))+16)
    gw(tm(gr(5,1),gr(5,0)),(td(gr(5,1),gr(5,0)))+16,gr(tm(gr(5,1),gr(5,0)),(td(gr(5,1),gr(5,0)))+16)+1)
    t2=gr(4,1)
    t3=td(t2,t1)
    gw(4,1,t3)
    t0=t0+1
    t0=t0*gr(4,1)
    gw(4,1,t0)

    return (7)if(gr(5,1)>gr(2,1))else(4)
def _7():
    gw(2,1,gr(5,1))
    return 4
def _8():
    gw(0,3,0)
    gw(1,3,0)
    gw(7,1,-1)
    sa(5)
    sa(0)
    sa(gr(0,3))
    sa(gr(0,3)-gr(7,1))
    return 9
def _9():
    return (17)if(sp()!=0)else(10)
def _10():
    sp();
    sa(sr());
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(tm(sr(),gr(5,0)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(5,0)))

    sa(sp()+3)

    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    return 11
def _11():
    sa(sp()+1)


    return (12)if((sr()-gr(2,0))!=0)else(13)
def _12():
    sa(sr());
    sa(tm(sr(),gr(5,0)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(5,0)))

    sa(sp()+3)

    v0=sp()
    sa(gr(sp(),v0))
    sa(sr()-gr(7,1))
    return 9
def _13():
    global t4
    gw(9,1,0)
    t4=gr(0,3)
    sp();
    return 14
def _14():
    sa(gr(9,1))

    return (15)if((gr(9,1)-gr(3,0))!=0)else(16)
def _15():
    global t0
    global t4
    sa(sp()+1)

    sa(sr());
    sa(sr());
    gw(9,1,sp())
    sa(tm(sp(),gr(5,0)))

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(5,0)))

    sa(sp()+3)

    v0=sp()
    t0=gr(sp(),v0)
    t4=t4+t0
    return 14
def _16():
    global t4
    sys.stdout.write(str(t4)+" ")
    sys.stdout.flush()

    sp();
    sp();
    return 33
def _17():
    return (18)if(sr()>gr(7,1))else(20)
def _18():
    gw(7,1,sp())
    return 19
def _19():
    global t0
    t0=1
    return 11
def _20():
    gw(8,1,sp())
    sa(sr());
    return 21
def _21():
    sa(sp()-1)


    return (22)if(sr()!=-1)else(28)
def _22():
    sa(sr());
    sa(tm(sr(),gr(5,0)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(5,0)))

    sa(sp()+3)

    v0=sp()
    sa(gr(sp(),v0))
    sa(sr());
    sa(sr());

    return (23)if(sp()!=0)else(29)
def _23():
    sa(sp()-gr(8,1))


    return (24)if(sp()!=0)else(27)
def _24():
    sa((1)if(sp()<gr(8,1))else(0))


    return (25)if(sp()!=0)else(26)
def _25():
    sp();
    return 11
def _26():
    global t0
    sa(sr());
    gw(6,1,sp())
    sa(sr()+1)
    sa(tm(sr(),gr(5,0)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(5,0)))

    sa(sp()+3)

    v0=sp()
    t0=gr(sp(),v0)
    gw(tm(gr(6,1)+1,gr(5,0)),(td(gr(6,1)+1,gr(5,0)))+3,gr(tm(gr(6,1),gr(5,0)),(td(gr(6,1),gr(5,0)))+3))
    gw(tm(gr(6,1),gr(5,0)),(td(gr(6,1),gr(5,0)))+3,t0)
    return 21
def _27():
    sp();
    sa(sp()+1)

    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(tm(sr(),gr(5,0)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(5,0)))

    sa(sp()+3)

    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(0)
    return 28
def _28():
    sp();
    return 19
def _29():
    global t0
    global t1
    t0=3
    t1=1
    sp();
    sp();
    return 26
def _30():
    return (3)if((((1)if((gr(3,0)-(gr(3,1)-gr(4,1)))>1)else(0))+((1)if(gr(4,1)<=gr(3,1))else(0))+((1)if(gr(tm(gr(3,0)-(gr(3,1)-gr(4,1)),gr(5,0)),(td(gr(3,0)-(gr(3,1)-gr(4,1)),gr(5,0)))+3)>gr(4,1))else(0)))!=3)else(31)
def _31():
    gw(tm(gr(3,0)-(gr(3,1)-gr(4,1)),gr(5,0)),(td(gr(3,0)-(gr(3,1)-gr(4,1)),gr(5,0)))+3,gr(4,1))
    return 3
def _32():
    sa(sp()-1)

    sa(sr());
    sa(gr(4,0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(tm(sr(),gr(5,0)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(5,0)))

    sa(sp()+3)

    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(tm(sr(),gr(5,0)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(5,0)))

    sa(sp()+8)

    sa(sp()+8)

    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());
    return 1
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27,_28,_29,_30,_31,_32]
c=0
while c<33:
    c=m[c]()
