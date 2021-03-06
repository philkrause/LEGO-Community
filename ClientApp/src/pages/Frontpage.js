import React from 'react'
import FrontInfo from '../components/FrontIntro'
import AllProjects from '../components/AllProjects'
import '../css/index.css'
import SideNav from '../components/SideNav'

export default function FrontPage() {

  return (
    <>
      <FrontInfo />
      <section>
        <SideNav />
        <div>
          <AllProjects />
        </div>
      </section>
    </>
  )
}