<template>
	<div class="calendar">
		<h1>This is THE ULTIMA CALENDAR</h1>
		<ul>
			<li v-for="event in events" :key="event.milongaEventID">
				{{event.name}}
			</li>
		</ul>
	</div>
</template>

<script lang="ts">
import jsonEvents from "./eventos-franco.json";
export default {
	data() {
		return {
			events: jsonEvents,
		};
	},
};
</script>
