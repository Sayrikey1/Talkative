using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Talkative.Domain.Talks;
using Talkative.Application.Talks.Interfaces;

namespace Talkative.Application.Talks.Services;

    public class TalksService : ITalksService
    {

        private readonly ITalksRepository _talksRepository;

        public TalksService(ITalksRepository talksRepository)
        {
           _talksRepository = talksRepository;
        }

        public Talk CreateTalk(Guid CreatedBy, Guid SecondParty)
        {
            var talk = new Talk(createdBy , secondParty);

            _talksRepository.Add(chat);

            return talk;
        }
    }