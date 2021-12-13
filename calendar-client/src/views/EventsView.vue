<template>
	<div class="calendar">
		<h1>This is THE ULTIMA CALENDAR</h1>
		<calendar></calendar>

	</div>
</template>

<script lang="ts">
import Calendar from '../components/Calendar.vue';

export default {
	name: "EventsView",
	components: {
		Calendar
	},
};
</script>
