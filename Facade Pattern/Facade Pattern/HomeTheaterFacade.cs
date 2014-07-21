using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade_Pattern
{
    class HomeTheaterFacade
    {
        Amplifier amp;
        Tuner tuner;
        DvdPlayer dvd;
        CdPlayer cd;
        Projector projector;
        TheaterLights lights;
        Screen screen;
        PopcornPopper popper;

        public HomeTheaterFacade(Amplifier amp,
                 Tuner tuner,
                 DvdPlayer dvd,
                 CdPlayer cd,
                 Projector projector,
                 Screen screen,
                 TheaterLights lights,
                 PopcornPopper popper)
        {
            this.amp = amp;
            this.tuner = tuner;
            this.dvd = dvd;
            this.cd = cd;
            this.projector = projector;
            this.screen = screen;
            this.lights = lights;
            this.popper = popper;
        }

        public void watchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie...");
            popper.on();
            popper.pop();
            lights.dim(10);
            screen.down();
            projector.on();
            projector.wideScreenMode();
            amp.on();
            amp.setDvd(dvd);
            amp.setSurroundSound();
            amp.setVolume(5);
            dvd.on();
            dvd.play(movie);
        }

        public void endMovie()
        {
            Console.WriteLine("Shutting movie theater down...");
            popper.off();
            lights.on();
            screen.up();
            projector.off();
            amp.off();
            dvd.stop();
            dvd.eject();
            dvd.off();
        }

        public void listenToCd(String cdTitle)
        {
            Console.WriteLine("Get ready for an audiopile experence...");
            lights.on();
            amp.on();
            amp.setVolume(5);
            amp.setCd(cd);
            amp.setStereoSound();
            cd.on();
            cd.play(cdTitle);
        }

        public void endCd()
        {
            Console.WriteLine("Shutting down CD...");
            amp.off();
            amp.setCd(cd);
            cd.eject();
            cd.off();
        }

        public void listenToRadio(double frequency)
        {
            Console.WriteLine("Tuning in the airwaves...");
            tuner.on();
            tuner.setFrequency(frequency);
            amp.on();
            amp.setVolume(5);
            amp.setTuner(tuner);
        }

        public void endRadio()
        {
            Console.WriteLine("Shutting down the tuner...");
            tuner.off();
            amp.off();
        }
    }
}
