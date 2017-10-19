#!/usr/bin/env python2

# transpiled with BefunCompile v1.3.0 (c) 2017
import sys
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
x0=4818
def _0():
    sa(1488)
    sa(1800)
    sa(1800)
    return 1
def _1():
    global x0
    return (14)if(((((x0%10)+2)*(((x0/10)%10)+2)*((((x0/10)/10)%10)+2)*((((x0/10)/10)/10)+2))-((((x0+3330)%10)+2)*((((x0+3330)/10)%10)+2)*(((((x0+3330)/10)/10)%10)+2)*(((((x0+3330)/10)/10)/10)+2)))!=0)else(2)
def _2():
    global t0
    v0=sp()
    sa(sp()-v0)

    t0=sp()

    return (14)if((t0)!=0)else(3)
def _3():
    sa(sr());

    return (13)if(sr()>9999)else(4)
def _4():
    sa(sr());

    return (6)if((sr()%2)!=0)else(5)
def _5():
    global t0
    global t1
    global t2
    global t3
    global x0
    t0=0
    sp();
    sp();
    sa(sp()+1)

    sa(sr());
    sa(sr());
    t0=(sr()%10)+2
    sa(sp()/10);

    t1=(sr()%10)+2
    sa(sp()/10);

    t2=(sr()%10)+2
    sa(sp()/10);

    sa(sp()+2)

    sa(t2)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()*sp());

    t3=sp()
    t2=t1*t3
    sa(t0*t2)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+3330)

    x0=sp()
    sa(sr());
    return 1
def _6():
    return (7)if((sr()%3)!=0)else(5)
def _7():
    global x0
    x0=sp()
    sa(7)
    sa(x0%7)
    return 8
def _8():
    return (9)if(sp()!=0)else(5)
def _9():
    global x0
    return (12)if(sr()>(x0/2))else(10)
def _10():
    global t0
    global t1
    global x0
    global t2
    t0=sr()-2
    t1=x0
    t2=tm(t1,t0)

    return (11)if((t2)!=0)else(5)
def _11():
    global t0
    global x0
    t0=x0
    sa(sp()+6)

    sa(sr());
    sa(t0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa(tm(sp(),v0))
    return 8
def _12():
    global t0
    global t1
    sp();
    sa(sp()+3330)

    t0=(1)if(sr()>9999)else(0)
    t1=0

    return (13)if((t0)!=0)else(4)
def _13():
    sp();
    sa(sr());
    sys.stdout.write(str(sp())+" ")
    sys.stdout.flush()

    sys.stdout.write(chr(32))
    sys.stdout.flush()

    sa(sp()+3330)

    sa(sr());
    sys.stdout.write(str(sp())+" ")
    sys.stdout.flush()

    sys.stdout.write(chr(32))
    sys.stdout.flush()

    sa(sp()+3330)

    sys.stdout.write(str(sp())+" ")
    sys.stdout.flush()
    return 15
def _14():
    global t0
    global t1
    global t2
    global t3
    global x0
    sp();
    sp();
    sa(sp()+1)

    sa(sr());
    sa(sr());
    t0=(sr()%10)+2
    sa(sp()/10);

    t1=(sr()%10)+2
    sa(sp()/10);

    t2=(sr()%10)+2
    sa(sp()/10);

    sa(sp()+2)

    sa(t2)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()*sp());

    t3=sp()
    t2=t1*t3
    sa(t0*t2)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+3330)

    x0=sp()
    sa(sr());
    return 1
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14]
c=0
while c<15:
    c=m[c]()
