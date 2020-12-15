# ADR 0001: Programming Language

- **Status**: Accepted (December 17, 2020)
- **Decision**: C# (.NET Core)

## Contents

- [Context](#context)
- [Breakdown](#breakdown)
  - [C#](#c-net-core)
  - [Java](#java-jakarta-enterprise-edition)
  - [JavaScript](#javascript-node-js)
  - [PHP](#php)
- [Considerations](#considerations)

## Context

In initial planning for the development of the OpenTMS system an early problem
that was encountered was what programming language to use. There are many
options available, and this document seeks to break down the rationale behind
the decision.

First, let's look at the major contenders. We'll cover the specifics shortly.
They are:

- [C#](#c-net-core)
- [Java](#java-jakarta-enterprise-edition)
- [JavaScript](#javascript-node-js)
- [PHP](#php)

There are some notable omissions from that list, namely C++, Go, Python and
Ruby. Honestly, I really just feel they aren't a good fit for this project for
various reasons.

## Breakdown

### C# (.NET Core) {:#c-net-core}

C#, and more specifically within our context .NET Core, is very powerful and
very flexible; however, it does have a few drawbacks. Ultimately the decision
between C# and Node.js was quite difficult, but it is our hope that our
rationale is well understood.

Let's begin with what C# does well. In terms of performance, it's very fast.
The language is also fairly mature, and backed by one of the largest tech
companies in America: Microsoft. C# is also very beginner friendly and
approachable. Additionally, in June 2016 C#, and more broadly .NET, went
open source and cross platform for the first time under Microsoft's direction.
Another huge boon is that C# has inter-module loading and code sharing
capabilities, meaning we can expose an API in our application that developers
can use and improve upon, and then we can load their code back into the core
and start the process anew.

With all of that said, C# does come with it's own drawbacks. While .NET Core is
cross platform, it's implementation (particularly on Linux) is mediocre at
best. This could prove to be problem, but we'll discuss that later. Another
problem with .NET Core, ironically, is its developer: Microsoft. Microsoft has
a long and storied history of killing products with little to no warning simply
because it "no longer fits in their vision" (paraphrasing). Will .NET Core
suffer a similar fate? It's not likely since it's an open source project, and
someone else could just take the reigns (side note: I'm sure Facebook or
Google would kill for the opportunity)

### Java (Jakarta Enterprise Edition) {:#java-jakarta-enterprise-edition}

Java is the second oldest language we are going to look at. What we now know
as Java Standard Edition version 1, which at the time was just called Java 1.0,
was released on January 23, 1996. What we now know as Java Enterprise Edition
didn't come about until a few years later when J2EE (Java 2 Enterprise
Platform) was released on December 12, 1999. At the time, Java was owned by
Sun Microsystems prior to being purchased by the Oracle Corporation on January
27, 2010. Prior to the acquisition, however, in May 2007, Java was open sourced
by Sun Microsystems. After the acquisition in 2010, both Java SE and Java EE
were submitted to the Eclipse Foundation for maintenance.

Java has existed for a very long time and, as a result, has a very large user
base in addition to it's many platforms, implementations and uses. Much like
C#, it is also very beginner friendly and approachable. In fact, Java is the
programming language taught at most universities because it is so beginner
friendly and teaches all of the OOP principles in a single language. Also due
to Java's long history, it is supported by many cloud providers including
Google Cloud, Microsoft Azure, and Amazon Web Services to name a few. Java is
also the language that many standards are created in and optimized for.
Standards in the regard refers more to general standards such as the Extensible
Name and Address Language (xNAL), as opposed to technological standards like
the Hypertext Markup Language, Version 5 (HTML5).

Java has one major drawback though: speed. While modern versions and alternate
implementations of the JVM have improved this, Java still lags considerably
behind .NET and Node.js in terms of performance. Additionally, despite the fact
that many standards are first implemented in Java, the Java versions still seem
to lag behind those of other languages, which is a pretty good indicator that
much of the community has moved on. Java also does support asynchronous
programming, but it is anything but fun, requiring developers to start tasks
and continually poll them to check for completion.

### JavaScript/TypeScript/CoffeeScript (Node.js) {:#javascript-node-js}

Originally released in 2009 for *nix systems and 2011 for Windows, Node.js has
quickly become the defacto standard for web development, and it's easy to see
why. The Node.js community has exploded over time and many people now confuse
the programming language(s) with the platform.

Node.js has many advantages, including it's rapid project setup; a quick
`npm init` or `yarn init` is all you really need to get up and going. Also,
the Node.js community is a very active and engaged one. Not to mention, you
can find a package for just about anything you could ever want. If you pair
Node.js with TypeScript for type checking, you have a contender that can give
many more feature packed languages a run for their money.

That's not to say there is nothing wrong with Node.js, far from it. First, it
suffers from the Java problem in that it is significantly slower than many of
the other languages in this comparison. Furthermore, it's very difficult to
create an extensible application. That's not to say it cannot be done, it's
just very difficult. Furthermore, the only way to securely serve a Node.js is
to run a reverse proxy, which adds even more overhead. It's also very difficult
to host Node.js applications in the cloud as many hosting providers don't
support it.

### PHP

Ah yes, PHP, the grandfather of the internet as we know it today. Having first
appeared in 1995. Prior to the advent of this once ubiquitous programming
language, much of the web was just static web pages. That's not to say that
PHP is dead, but it is very quickly being replaced by JavaScript in many
places, and we'll soon see there's probably a reason for that.

PHP is extremely simple, and that was by design, since the language was one of
the pioneers of the early internet. Nothing like it had really been seen
before, and no language has really had the same impact on the internet that
PHP did, though JavaScript is very much trying to. Much like the other mature
and robust languages, there exists a plethora of libraries and frameworks built
on PHP.

That said, PHP has a fair share of drawbacks. Firstly, PHP has had many major
security flaws in its past, and while all languages have flaws from time to
time, there seems to be an entire community of security researchers dedicated
just to finding flaws in PHP, and that's not a good look. Furthermore, while
PHP still has a presence on the internet today, likely due to the proliferation
of content management systems like WordPress, that seems to be changing
quickly, and PHP seems to be a dying language.

## Considerations

When choosing a language, there were really 3 main points to hit: performance,
static typing, and runtime extensibility, and honestly C# nails all 3 of those
points. Over the coming weeks, maybe months, we'll begin to work on an API and
provide more concrete information about how this will work long term.

Additionally, with regard to the few faults C# does have, many of them we feel
can easily be overcome. Many sysadmins are familiar with having to install some
prerequisite software for applications, so that hopefully won't be a lasting
issue. Furthermore, since much of the business world runs on Microsoft services
already, it can be hoped that many of them use Microsoft Azure, which has
native support for ASP.NET Core applications. Additionally, with regard to
Microsoft's history of abandoned products and services, one can hope that
.NET Core will not suffer the same fate, but only time will tell. Platforms
come and go, that's just how progress works. If that does happen, we'll revisit
this issue. Until then, it is decided.
