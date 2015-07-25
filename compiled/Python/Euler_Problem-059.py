#!/usr/bin/env python3
# compiled with BefunCompile v1.0.7 (c) 2015
import gzip, base64
_g = ("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"
  + "XmAvsEZg/wPTb2bdgHYAAA==")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<237 and y<128):
        return g[y*237 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<237 and y<128):
        g[y*237 + x]=v;
def td(a,b):
    return bool(random.getrandbits(1))
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
    gw(1,0,17)
    gw(2,0,0)
    gw(3,0,0)
    gw(2,3,0)
    return 1
def _1():
    global t0
    gw((tm(gr(3,0),100))+8,td(gr(3,0),100),((gr(gr(2,0)*3,gr(1,0))-48)*10)+(gr((gr(2,0)*3)+1,gr(1,0))-48))
    gw(3,0,gr(3,0)+1)
    t0=gr(2,0)+1
    return (34)if(gr(2,0)!=11)else(2)
def _2():
    gw(1,0,gr(1,0)+1)
    gw(2,0,0)
    return 3
def _3():
    return (1)if((((0)if(gr(1,0)-117!=0)else(1))+((0)if(gr(2,0)-1!=0)else(1)))!=2)else(4)
def _4():
    gw(5,1,0)
    return 5
def _5():
    gw(6,1,0)
    return 6
def _6():
    global t0
    global t0
    global t3
    t0=gr(5,1)
    gw(1,1,gr(6,1))
    gw(2,1,t0)
    gw(3,1,1)
    t3=0
    return 7
def _7():
    return (8)if(gr(1,1)+gr(2,1)==0)else(33)
def _8():
    global t3
    global t0
    global t0
    global t0
    gw(gr(5,1)+109,gr(6,1),t3)
    t0=gr(6,1)+1
    gw(6,1,gr(6,1)+1)
    t0=t0-128
    return (6)if((t0)!=0)else(9)
def _9():
    global t0
    global t0
    global t0
    t0=gr(5,1)+1
    gw(5,1,gr(5,1)+1)
    t0=t0-128
    return (5)if((t0)!=0)else(10)
def _10():
    gw(1,3,17576)
    return 11
def _11():
    global t0
    global t0
    t0=gr(1,3)
    gw(1,3,gr(1,3)-1)
    return (16)if((t0)!=0)else(12)
def _12():
    gw(1,5,1200)
    gw(2,5,0)
    return 13
def _13():
    global t0
    global t0
    global t0
    t0=gr(gr((tm(gr(1,5),100))+8,td(gr(1,5),100))+109,gr((tm(gr(1,5),3))+4,3))
    gw(2,5,gr(gr((tm(gr(1,5),100))+8,td(gr(1,5),100))+109,gr((tm(gr(1,5),3))+4,3))+gr(2,5))
    gw((tm(gr(1,5),100))+8,td(gr(1,5),100),t0)
    t0=gr(1,5)
    return (15)if((gr(1,5))!=0)else(14)
def _14():
    print(gr(2,5),end="",flush=True)
    return 35
def _15():
    global t0
    global t0
    t0=t0-1
    gw(1,5,t0)
    return 13
def _16():
    global t0
    global t0
    global t1
    global t1
    global t0
    global t0
    global t0
    t0=gr(1,3)
    gw(1,2,(tm(gr(1,3),26))+97)
    t0=td(t0,26)
    t1=(tm(t0,26))+97
    gw(2,2,t1)
    t0=td(t0,26)
    t0=t0+97
    gw(3,2,t0)
    gw(3,4,0)
    gw(1,4,0)
    gw(2,4,1)
    sa(1200)
    sa(gr(gr(8,12)+109,gr(gr(2,4),2)))
    sa((1)if(gr(gr(8,12)+109,gr(gr(2,4),2))<32)else(0))
    return 17
def _17():
    return (18)if(sp()!=0)else(19)
def _18():
    sp()
    sp()
    return 11
def _19():
    return (18)if(sr()>126)else(20)
def _20():
    global t0
    global t0
    global t0
    t0=gr(1,4)
    gw(1,4,gr(1,4)+1)
    t0=t0-9
    return (21)if((t0)!=0)else(18)
def _21():
    sa(sp()-32);
    return (32)if(sp()!=0)else(22)
def _22():
    global t0
    global t0
    global t0
    t0=(tm(sr(),3))+1
    gw(2,4,t0)
    sa(sr())
    sa((tm(sr(),100))+8)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),100))
    v0=sp()
    sa(gr(sp(),v0))
    sa(sp()+109);
    sa(gr(gr(2,4),2))
    v0=sp()
    t0=gr(sp(),v0)
    return (11)if(t0<32)else(23)
def _23():
    return (31)if(t0>126)else(24)
def _24():
    global t0
    global t0
    t0=t0-101
    return (25)if((t0)!=0)else(30)
def _25():
    sa(sr())
    return 26
def _26():
    return (29)if(sp()!=0)else(27)
def _27():
    sp()
    return (28)if(gr(3,4)>gr(2,3))else(11)
def _28():
    global t0
    global t1
    global t1
    global t0
    gw(2,3,gr(3,4))
    t0=gr(3,2)
    t1=gr(2,2)
    gw(4,3,gr(1,2))
    gw(5,3,t1)
    gw(6,3,t0)
    return 11
def _29():
    sa(sp()-1);
    return 22
def _30():
    gw(3,4,gr(3,4)+1)
    sa(sr())
    return 26
def _31():
    sp()
    return 11
def _32():
    global t0
    global t0
    sa(sp()-1);
    t0=(tm(sr(),3))+1
    gw(2,4,t0)
    sa(sr())
    sa((tm(sr(),100))+8)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),100))
    v0=sp()
    sa(gr(sp(),v0))
    sa(sp()+109);
    sa(gr(gr(2,4),2))
    v0=sp()
    sa(gr(sp(),v0))
    sa((1)if(sr()<32)else(0))
    return 17
def _33():
    global t0
    global t1
    global t2
    global t3
    t0=tm((tm(gr(1,1),2))+(tm(gr(2,1),2)),2)
    t1=gr(3,1)
    gw(3,1,gr(3,1)*2)
    gw(1,1,td(gr(1,1),2))
    gw(2,1,td(gr(2,1),2))
    t2=t0*t1
    t3=t3+t2
    return 7
def _34():
    global t0
    gw(2,0,t0)
    return 3
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27,_28,_29,_30,_31,_32,_33,_34]
c=0
while c<35:
    c=m[c]()