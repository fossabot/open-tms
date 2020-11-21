# OpenTMS

OpenTMS is an open source Transportation Management System (TMS) aimed at small
to medium sized transportation companies. The application is/will be written
using NodeJS on the backend for the server, React for the client, and will have
a rich API to allow companies, administrators, and developers to tailor the
systen to their specific needs. This repository is pretty barren at the moment,
but that will change in due time.


## What is a Transportation Management System?

A Transportation Management System (or Software), sometimes called a Fleet
Management System (or Software), is a system for transportation companies to
track various metrics about their fleets, such as vehicle utilization, fuel
economy, fuel cost, and much more. These systems are very important for the
transportation industry; and unfortunately for many small and mid sized
transportation companies. the industry is dominated by a few key players
that use outdated technologies and charge quite a lot for the privilege. This
project seeks to solve that problem. By providing a high quality free
alternative, we hope to make the industry as a whole better!


## Why is there so little here?

Honestly, its because the code base is very limited at this point in time, and
I'm not 100% sure what direction this project is going just yet. I do have some
ideas in mind and I have a good portion of the base code finished for the core,
server, and API; but it's very sloppy and changes regularly. I personally don't
think it's fair to those who may be genuinely interested in the future of this
project to put up code that's constantly changing. That said, progress is being
made on this project...slowly. I work in the transportation industry myself, so
I have my work schedule to contend with. However, I hope to be able to publish
at least 1 of the 4 packages soon.


## How is this project structured?

It's a microrepo, hence the `lerna.json` file. So, all 4 of the major packages
along with any first party plugins will be published to this repository.
Speaking of the 4 major packages, those are as follows:

- `core`: The core package will contain all of the heavy lifting code. Things
    like models, services, and loaders will be contained here.
- `client`: The client package will contain the React client application.
    Personally, I'm not a fan of React, and I much prefer Vue, but React is
    far more common and standardized, so it's simply the better option here.
- `server`: The server package will contain the Express server application.
    This will be responsible for shuttling requests between the React client
    application and the database managed by the core. The server will also
    mostly handle authentication. More on that later.
- `api`: The API package will contain everything you need to make OpenTMS
    work for you and your business. This package will contain the files you
    need to add plugins, models, and so much more.
