import React from "react";
import SingleTeamCard from "./SingleTeamCard";
import "swiper/css/autoplay";
// import Swiper core and required modules
import { Swiper, SwiperSlide } from "swiper/react";
import SwiperCore, {
  Autoplay,
  EffectFade,
  Navigation,
  Pagination,
} from "swiper";
import { copy, identity } from "../../../data/data";

SwiperCore.use([Navigation, Pagination, EffectFade, Autoplay]);
function TeamWrap(props) {
    const teamSlider = {
      autoplay:{
        delay: 2500000,
        // delay: 2500,
        disableOnInteraction: false,
      },
        loop: true,
        slidesPerView: 2,
        // slidesPerView: 3,
        spaceBetween: 30,
        pagination: {
            // el: ".swiper-pagination",
            clickable: true,
        },
        breakpoints: {
            320: {
                slidesPerView: 1,
            },
            576: {
                slidesPerView: 2,
            },
            992: {
                slidesPerView: 3,
            }
        }
    }
    
  const teamMembersFromCopy = Object.values(copy.team);
  const teamMembers = teamMembersFromCopy.map(member => {
    return {
      name: member.name,
      title: member.title,
      image: member.image,
      social: member.social
    };
  });

  return (
    <>
      <section className="our-team sec-mar">
        <div className="container">
          <div
            className="title-wrap  wow animate fadeInUp"
            data-wow-delay="200ms"
            data-wow-duration="1500ms"
          >
            <div className={`${"sec-title"} ${props.white}`}>
              <span>{copy.chisiamo.title}</span>
              <h2>Il Team di {identity.name}</h2>
              <p>
                {identity.team}
              </p>
            </div>
          </div>
          <Swiper {...teamSlider} className="swiper team-slider">
            <div className="swiper-wrapper">
              
              {
                teamMembers.map(member => {
                  return(
                    <SwiperSlide
                      className="swiper-slide wow animate fadeInUp"
                      // data-wow-delay="200ms"
                      // data-wow-duration="1500ms"
                    >
                      <SingleTeamCard
                        image={member.image}
                        name={member.name}
                        title={member.title}
                        social={member.social}
                      />
                    </SwiperSlide>
                  )
                })
              }

              {/* <SwiperSlide
                className="swiper-slide wow animate fadeInUp"
                data-wow-delay="200ms"
                data-wow-duration="1500ms"
              >
                <SingleTeamCard
                  image={"/img/team/team-1.jpg"}
                  name="Thoren Okendhild"
                  title="Executive Chairman"
                />
              </SwiperSlide>
              <SwiperSlide
                className="swiper-slide wow animate fadeInUp"
                data-wow-delay="400ms"
                data-wow-duration="1500ms"
              >
                <SingleTeamCard
                  image={"/img/team/team-2.jpg"}
                  name="Lincoln Anthony"
                  title="Software Engeenier"
                />
              </SwiperSlide>
              <SwiperSlide
                className="swiper-slide wow animate fadeInUp"
                data-wow-delay="600ms"
                data-wow-duration="1500ms"
              >
                <SingleTeamCard
                  image={"/img/team/team-3.jpg"}
                  name="Adrian Eodri"
                  title="UI/UX Designer"
                />
              </SwiperSlide> */}
            </div>
            {/* This down here are clickable dots for scroll (paginations) between SwiperSlide. Take a look at 'el: ".swiper-pagination",' in 'teamSlider' const at the top of the page */}
            {/* <div className="swiper-pagination" /> */}
          </Swiper>
        </div>
      </section>
    </>
  );
}

export default TeamWrap;
