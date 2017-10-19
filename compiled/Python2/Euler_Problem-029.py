#!/usr/bin/env python2

# transpiled with BefunCompile v1.3.0 (c) 2017
import sys
import zlib, base64
_g = ("AR+LCAAAAAAABADt1NFOwjAUBuBXGd24WTM9HWzAQhp8AN8At5sl9bJXvTI8u6erEEKGOsVo6v8nhNK1Z+cbFJf801AsmehOYwnccMMNN9xxBG644YYb7jgCN9xwww13"
  + "HIEbbrjhhjuOwA033HDDHUfghhtuuOGOI3DDDTfccMcRuOGGG2644wjcyPXoRDw9Hh4OPs8zIYfkMs8VWdEcpJB5VUke96LMlSzJut9u+SaZrtj+QBcfZWqXoUexFJfN"
  + "7u4MyarKjvNjhbfjW/1vJCQbbWd00lJ1z/ezVF+We5d07RnrYpa67vN1RiqUZBin12Qb2q/JWH6polFF2nYZD/yb6Puwgq/tS0qM5rXKOq14t7JLspoqsvyh5mHNc2ZJ"
  + "Jq/IyIZPydzP2Hqo68sNZV2XkVrx8k2+8hukIjP3I9mshlLF0MJbexuyC77/gsyGjGlefOf+/HHJ4RhmTodr560Pg50+gdxx1nXttKcU0nZtOmsKdfZtTK/zreOis6C0"
  + "2Wnm6tovEW+2/S9ky3/OYZAkr+fUiHQoOQAA")
g = base64.b64decode(_g)[1:]
for i in range(ord(base64.b64decode(_g)[0])):
    g = zlib.decompress(g, 16+zlib.MAX_WBITS)
g=list(map(ord, g))
def gr(x,y):
    if(x>=0 and y>=0 and x<248 and y<59):
        return g[y*248 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<248 and y<59):
        g[y*248 + x]=v;
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
    gw(1,0,357913941)
    gw(10,0,9802)
    gw(2,0,201)
    sa(gr(2,0))
    sa(0)
    sa(gr(2,0))
    gw(8,0,52)
    return 1
def _1():
    global t0
    sa(gr(8,0))
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    t0=gr(8,0)-1

    return (31)if(gr(8,0)!=2)else(2)
def _2():
    sa(sp()-1)

    sa(sr());

    return (3)if(sp()!=0)else(4)
def _3():
    gw(8,0,52)
    sa(sr());
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 1
def _4():
    gw(8,0,100)
    sp();
    sa(100)
    sa(gr(8,0))
    sa(100)
    return 5
def _5():
    sa(gr(2,0)-1)
    sa(gr(2,0)-1)
    gw(gr(2,0),1,0)
    return 6
def _6():
    return (7)if(sp()!=0)else(8)
def _7():
    sa(sr());
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sp()-1)

    sa(sr());
    return 6
def _8():
    gw(gr(2,0),1,1)
    sp();
    gw(4,0,sp())
    return 9
def _9():
    gw(5,0,0)
    gw(6,0,gr(2,0))
    return 10
def _10():
    global t0
    global t1
    t0=(gr(gr(6,0),1)*gr(4,0))+gr(5,0)
    gw(gr(6,0),1,((gr(gr(6,0),1)*gr(4,0))+gr(5,0))%10)
    t1=gr(6,0)-1

    return (30)if(gr(6,0)!=1)else(11)
def _11():
    sa(sp()-1)

    sa(sr());

    return (9)if(sp()!=0)else(12)
def _12():
    gw(7,0,1)
    sp();
    sa(tm(gr(gr(7,0),1),gr(1,0)))
    return 13
def _13():
    global t0
    t0=gr(7,0)+1
    gw(7,0,gr(7,0)+1)
    t0=t0-gr(2,0)
    t0=t0-1

    return (29)if((t0)!=0)else(14)
def _14():
    sa(gr(2,0))
    gw(9,0,52)
    return 15
def _15():
    global t0
    gw(3,0,sp())
    t0=gr(gr(3,0),gr(9,0))
    sa(sr());

    return (16)if((gr(gr(3,0),gr(9,0)))!=0)else(28)
def _16():
    global t0
    global t1
    sa(sp()-t0)

    t1=sp()

    return (17)if((t1)!=0)else(22)
def _17():
    global t0
    t0=gr(9,0)-1
    sa(gr(3,0))

    return (21)if(gr(9,0)!=2)else(18)
def _18():
    sa(sp()-1)


    return (20)if(sr()!=1)else(19)
def _19():
    return 32
def _20():
    gw(9,0,52)
    return 15
def _21():
    global t0
    gw(9,0,t0)
    return 15
def _22():
    gw(10,0,gr(10,0)-1)
    sp();
    return 23
def _23():
    global t0
    t0=gr(8,0)-1

    return (27)if(gr(8,0)!=2)else(24)
def _24():
    sa(sp()-1)


    return (25)if(sr()!=1)else(26)
def _25():
    gw(8,0,100)
    sa(sr());
    sa(gr(8,0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 5
def _26():
    sys.stdout.write(str(gr(10,0))+" ")
    sys.stdout.flush()

    sp();
    return 32
def _27():
    global t0
    gw(8,0,t0)
    sa(sr());
    sa(gr(8,0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 5
def _28():
    gw(gr(3,0),gr(9,0),sp())
    sp();
    return 23
def _29():
    sa(sp()*9)

    sa(sp()+gr(gr(7,0),1))

    sa(tm(sp(),gr(1,0)))
    return 13
def _30():
    global t1
    global t0
    gw(6,0,t1)
    t0=t0/10
    gw(5,0,t0)
    return 10
def _31():
    global t0
    gw(8,0,t0)
    sa(sr());
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 1
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27,_28,_29,_30,_31]
c=0
while c<32:
    c=m[c]()
