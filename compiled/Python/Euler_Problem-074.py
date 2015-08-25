#!/usr/bin/env python3
# compiled with BefunCompile v1.0.7 (c) 2015
import gzip, base64
_g = ("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")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<1224 and y<833):
        return g[y*1224 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<1224 and y<833):
        g[y*1224 + x]=v;
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
    gw(1,1,1224)
    gw(2,1,817)
    gw(3,1,1000000)
    gw(4,2,0)
    sa(gr(3,1)-1)
    gw(tm(gr(3,1)-1,gr(1,1)),(td(gr(3,1)-1,gr(1,1)))+4,0)
    return 1
def _1():
    sa(sr())
    return (26)if(sp()!=0)else(2)
def _2():
    gw(7,0,0)
    sp()
    sa(1)
    return 3
def _3():
    sa(sr())
    sa(gr(7,0))
    gw(7,0,gr(7,0)+1)
    sa(sp()+9);
    sa(0)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sp()*gr(7,0));
    return 4
def _4():
    return (3)if(gr(7,0)!=10)else(5)
def _5():
    gw(0,4,0)
    gw(tm(169,gr(1,1)),(td(169,gr(1,1)))+4,3)
    gw(tm(363601,gr(1,1)),(td(363601,gr(1,1)))+4,3)
    gw(tm(1454,gr(1,1)),(td(1454,gr(1,1)))+4,3)
    gw(tm(871,gr(1,1)),(td(871,gr(1,1)))+4,2)
    gw(tm(45361,gr(1,1)),(td(45361,gr(1,1)))+4,2)
    gw(tm(872,gr(1,1)),(td(872,gr(1,1)))+4,2)
    gw(tm(45362,gr(1,1)),(td(45362,gr(1,1)))+4,2)
    gw(1,2,1)
    gw(2,2,0)
    gw(9,2,0)
    gw(3,2,0)
    sp()
    sa(1)
    return 6
def _6():
    return (7)if(gr(gr(3,2)+9,2)!=gr(1,2))else(13)
def _7():
    sa(gr(1,2))
    sa(gr(2,2)+1)
    gw(2,2,gr(2,2)+1)
    sa(sp()+9);
    sa(2)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    gw(3,2,gr(3,2)+1)
    sa(0)
    sa(gr(1,2))
    return (24)if((gr(1,2))!=0)else(8)
def _8():
    sp()
    return 9
def _9():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    return (23)if(sp()!=0)else(10)
def _10():
    sa(sp()+sp());
    sa(sr())
    gw(1,2,sp())
    sa((1)if(sp()>gr(3,1))else(0))
    sa((0)if(sp()!=0)else(1))
    return (11)if(sp()!=0)else(6)
def _11():
    global t0
    t0=gr(tm(gr(1,2),gr(1,1)),(td(gr(1,2),gr(1,1)))+4)
    return (12)if((gr(tm(gr(1,2),gr(1,1)),(td(gr(1,2),gr(1,1)))+4))!=0)else(6)
def _12():
    global t0
    global t0
    t0=t0+gr(2,2)
    gw(2,2,t0)
    return 13
def _13():
    return (14)if(gr(2,2)!=60)else(22)
def _14():
    sa(1)
    sa((1)if(gr(10,2)>gr(3,1))else(0))
    return 15
def _15():
    return (17)if(sp()!=0)else(16)
def _16():
    global t0
    global t0
    sa(sr())
    sa(sr())
    t0=gr(2,2)+1
    sa(t0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa(sp()-v0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+9);
    sa(2)
    v0=sp()
    sa(gr(sp(),v0))
    sa(tm(sr(),gr(1,1)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(1,1)))
    sa(sp()+4);
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    return 17
def _17():
    return (21)if(sr()!=gr(3,2))else(18)
def _18():
    sp()
    return (20)if(sr()!=gr(3,1))else(19)
def _19():
    print(gr(4,2),end="",flush=True)
    sp()
    return 27
def _20():
    sa(sp()+1);
    sa(sr())
    gw(1,2,sp())
    gw(2,2,0)
    gw(9,2,0)
    gw(3,2,0)
    return 6
def _21():
    sa(sp()+1);
    sa(sr()+9)
    sa(2)
    v0=sp()
    sa(gr(sp(),v0))
    sa((1)if(sp()>gr(3,1))else(0))
    return 15
def _22():
    gw(4,2,gr(4,2)+1)
    return 14
def _23():
    sa(sp()+sp());
    return 9
def _24():
    sa((tm(sr(),10))+9)
    sa(0)
    v0=sp()
    sa(gr(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),10))
    sa(sr())
    return 25
def _25():
    return (24)if(sp()!=0)else(8)
def _26():
    sa(sp()-1);
    sa(sr())
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(tm(sr(),gr(1,1)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(1,1)))
    sa(sp()+4);
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    return 1
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26]
c=0
while c<27:
    c=m[c]()