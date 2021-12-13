<template>
    <div>
        <ul>
            <li v-for="event in events" :key="event.milongaEventID">
                {{event.name}}
            </li>
        </ul>
    </div>
</template>

<script>
import jsonEvents from "../assets/eventos-franco.json";

export default {
    // refs
    // https://vuejsexamples.com/a-simple-calendar-with-vue-js/
    // https://css-tricks.com/lets-make-a-vue-powered-monthly-calendar/
    //

    
    name: "Calendar",
    data() {
    return {
        events: jsonEvents,
    };
},
}
</script>

<style>

</style>