# compiled with BefunCompile v1.0.3 (c) 2015
# execute with at least Python3
from random import randint
import gzip, base64
_g="AR+LCAAAAAAABACtUE0PwiAM/St0nRcIWhgHtxDiL2EeTLhy4qT/3fqBmy7zYHxJQ9PXPl5bBCIKBv4A8QV/0gump2x6k8ny21EuyxZHqVcdJbuBxPm+5qoUSLCxiTrVJ3JHKX1gbmhOjQYso1EDK9qdo3yr86yVQZ9XdwrD9FVuLpdDE+OMRd8K9JbS9vDp7+XJyhkTQ3sXNPrJwnK7h0R1J3RcaZkwFoQa/o2pZseIkMkN2vBVfJ4uRHxmpQyAllxzXE5kWxapIa6IhbYwMAIAAA=="
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<80 and y<7):
        return g[y*80 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<80 and y<7):
        g[y*80 + x]=v;
def rd():
    return bool(random.getrandbits(1))
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
    return (9)if(sp()!=0)else(20)
def _1():
    return (16)if(sp()!=0)else(11)
def _2():
    return (18)if(sp()!=0)else(17)
def _3():
    return (14)if(sp()!=0)else(19)
def _4():
    return (7)if(sp()!=0)else(15)
def _5():
    return (21)if((0)if(((gr(3,0))-(100))!=0)else(1))else(8)
def _6():
    gw(9,0,1)
    gw(9,1,1)
    gw(2,0,0)
    gw(3,0,1)
    return 7
def _7():
    sa(gr(3,0))
    return 5
def _8():
    sa(1)
    sa(sp()+sp());
    sa(sr())
    gw(3,0,sp())
    sa(2)
    v0=sp()
    sa(td(sp(),v0))
    gw(4,0,sp())
    sa((gr(3,0))-((gr(4,0))*(2)))
    return 0
def _9():
    sa((gr((gr(4,0))+(9),(0)if((tm(gr(3,0),2))!=0)else(1)))+(gr((gr(4,0))+(8),(0)if((tm(gr(3,0),2))!=0)else(1))))
    gw((gr(4,0))+(9),tm(gr(3,0),2),(gr((gr(4,0))+(9),(0)if((tm(gr(3,0),2))!=0)else(1)))+(gr((gr(4,0))+(8),(0)if((tm(gr(3,0),2))!=0)else(1))))
    return 10
def _10():
    sa(1000000)
    v0=sp()
    sa((1)if(sp()>v0)else(0))
    sa((0)if((gr((gr(4,0))+(9),(0)if((tm(gr(3,0),2))!=0)else(1)))!=0)else(1))
    sa((0)if(((0)if((gr(((gr(4,0))+(9))-(1),(0)if((tm(gr(3,0),2))!=0)else(1)))!=0)else(1))!=0)else(1))
    return 1
def _11():
    gw(2,0,(gr(2,0))+(((0)if(((0)if(((gr(3,0))-((gr(4,0))*(2)))!=0)else(1))!=0)else(1))+(1)))
    gw((gr(4,0))+(9),tm(gr(3,0),2),0)
    sp()
    return 12
def _12():
    sp()
    return 13
def _13():
    sp()
    return 14
def _14():
    sa((gr(4,0))-(1))
    gw(4,0,(gr(4,0))-(1))
    sa((0)if(sp()!=0)else(1))
    return 4
def _15():
    sa((gr(3,0))-((gr(4,0))*(2)))
    v0=sp()
    sa(sp()-v0)
    return 0
def _16():
    sa((0)if(sp()!=0)else(1))
    return 2
def _17():
    gw(2,0,(gr(2,0))+(((0)if(((0)if(((gr(3,0))-((gr(4,0))*(2)))!=0)else(1))!=0)else(1))+(1)))
    gw((gr(4,0))+(9),tm(gr(3,0),2),0)
    return 12
def _18():
    sa((0)if(sp()!=0)else(1))
    return 3
def _19():
    gw(2,0,(gr(2,0))+(((0)if(((0)if(((gr(3,0))-((gr(4,0))*(2)))!=0)else(1))!=0)else(1))+(1)))
    gw((gr(4,0))+(9),tm(gr(3,0),2),0)
    return 13
def _20():
    sa((gr((gr(4,0))+(8),(0)if((tm(gr(3,0),2))!=0)else(1)))*(2))
    gw((gr(4,0))+(9),tm(gr(3,0),2),(gr((gr(4,0))+(8),(0)if((tm(gr(3,0),2))!=0)else(1)))*(2))
    return 10
def _21():
    sp()
    print(gr(2,0),end="",flush=True)
    return 22
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21]
c=6
while c<22:
    c=m[c]()