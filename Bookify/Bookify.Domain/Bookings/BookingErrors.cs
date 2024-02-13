﻿using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Bookings
{
    public sealed class BookingErrors
    {
        public static Error NotFound = new(
            "Booking.NotFound",
            "The booking with the soecified identifier was not found");

        public static Error Overlap = new(
            "Booking.Overlap",
            "The current booking is overlapping with an existing one");

        public static Error NotReserved = new(
            "Booking.NotReserved",
            "The booking is not pending");

        public static Error NotConfirmed = new(
            "Booking.NotConfirmed",
            "The booking is not confirmed");

        public static Error AlreadyStarted = new(
            "Booking.AlreadyStarted",
            "The booking has already started");
    }
}