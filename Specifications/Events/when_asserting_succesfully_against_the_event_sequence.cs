﻿/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 * --------------------------------------------------------------------------------------------*/
using System;
using Machine.Specifications;

namespace Dolittle.Machine.Specifications.Events
{

    [Subject("Asserting against the Uncommitted Event Stream")]
    public class when_asserting_succesfully_against_the_event_sequence : an_aggregate_root_with_uncommitted_events
    {
        It should_have_an_event_at_the_beginning = () => aggregate_root.ShouldHaveEvent<AnEvent>().AtBeginning();
        It should_have_another_event_at_the_end = () => aggregate_root.ShouldHaveEvent<AnotherEvent>().AtEnd();
        It should_have_an_event_at_sequence_number_1 = () => aggregate_root.ShouldHaveEvent<AnEvent>().AtSequenceNumber(1);
        It should_have_another_event_at_sequence_number_2 = () => aggregate_root.ShouldHaveEvent<AnotherEvent>().AtSequenceNumber(2);
    }
}