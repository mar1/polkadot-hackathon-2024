//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Substrate.NetApi.Generated.Model.polkadot_runtime_parachains.inclusion.pallet
{
    
    
    /// <summary>
    /// >> Error
    /// The `Error` enum of this pallet.
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> UnsortedOrDuplicateValidatorIndices
        /// Validator indices are out of order or contains duplicates.
        /// </summary>
        UnsortedOrDuplicateValidatorIndices = 0,
        
        /// <summary>
        /// >> UnsortedOrDuplicateDisputeStatementSet
        /// Dispute statement sets are out of order or contain duplicates.
        /// </summary>
        UnsortedOrDuplicateDisputeStatementSet = 1,
        
        /// <summary>
        /// >> UnsortedOrDuplicateBackedCandidates
        /// Backed candidates are out of order (core index) or contain duplicates.
        /// </summary>
        UnsortedOrDuplicateBackedCandidates = 2,
        
        /// <summary>
        /// >> UnexpectedRelayParent
        /// A different relay parent was provided compared to the on-chain stored one.
        /// </summary>
        UnexpectedRelayParent = 3,
        
        /// <summary>
        /// >> WrongBitfieldSize
        /// Availability bitfield has unexpected size.
        /// </summary>
        WrongBitfieldSize = 4,
        
        /// <summary>
        /// >> BitfieldAllZeros
        /// Bitfield consists of zeros only.
        /// </summary>
        BitfieldAllZeros = 5,
        
        /// <summary>
        /// >> BitfieldDuplicateOrUnordered
        /// Multiple bitfields submitted by same validator or validators out of order by index.
        /// </summary>
        BitfieldDuplicateOrUnordered = 6,
        
        /// <summary>
        /// >> ValidatorIndexOutOfBounds
        /// Validator index out of bounds.
        /// </summary>
        ValidatorIndexOutOfBounds = 7,
        
        /// <summary>
        /// >> InvalidBitfieldSignature
        /// Invalid signature
        /// </summary>
        InvalidBitfieldSignature = 8,
        
        /// <summary>
        /// >> UnscheduledCandidate
        /// Candidate submitted but para not scheduled.
        /// </summary>
        UnscheduledCandidate = 9,
        
        /// <summary>
        /// >> CandidateScheduledBeforeParaFree
        /// Candidate scheduled despite pending candidate already existing for the para.
        /// </summary>
        CandidateScheduledBeforeParaFree = 10,
        
        /// <summary>
        /// >> ScheduledOutOfOrder
        /// Scheduled cores out of order.
        /// </summary>
        ScheduledOutOfOrder = 11,
        
        /// <summary>
        /// >> HeadDataTooLarge
        /// Head data exceeds the configured maximum.
        /// </summary>
        HeadDataTooLarge = 12,
        
        /// <summary>
        /// >> PrematureCodeUpgrade
        /// Code upgrade prematurely.
        /// </summary>
        PrematureCodeUpgrade = 13,
        
        /// <summary>
        /// >> NewCodeTooLarge
        /// Output code is too large
        /// </summary>
        NewCodeTooLarge = 14,
        
        /// <summary>
        /// >> DisallowedRelayParent
        /// The candidate's relay-parent was not allowed. Either it was
        /// not recent enough or it didn't advance based on the last parachain block.
        /// </summary>
        DisallowedRelayParent = 15,
        
        /// <summary>
        /// >> InvalidAssignment
        /// Failed to compute group index for the core: either it's out of bounds
        /// or the relay parent doesn't belong to the current session.
        /// </summary>
        InvalidAssignment = 16,
        
        /// <summary>
        /// >> InvalidGroupIndex
        /// Invalid group index in core assignment.
        /// </summary>
        InvalidGroupIndex = 17,
        
        /// <summary>
        /// >> InsufficientBacking
        /// Insufficient (non-majority) backing.
        /// </summary>
        InsufficientBacking = 18,
        
        /// <summary>
        /// >> InvalidBacking
        /// Invalid (bad signature, unknown validator, etc.) backing.
        /// </summary>
        InvalidBacking = 19,
        
        /// <summary>
        /// >> NotCollatorSigned
        /// Collator did not sign PoV.
        /// </summary>
        NotCollatorSigned = 20,
        
        /// <summary>
        /// >> ValidationDataHashMismatch
        /// The validation data hash does not match expected.
        /// </summary>
        ValidationDataHashMismatch = 21,
        
        /// <summary>
        /// >> IncorrectDownwardMessageHandling
        /// The downward message queue is not processed correctly.
        /// </summary>
        IncorrectDownwardMessageHandling = 22,
        
        /// <summary>
        /// >> InvalidUpwardMessages
        /// At least one upward message sent does not pass the acceptance criteria.
        /// </summary>
        InvalidUpwardMessages = 23,
        
        /// <summary>
        /// >> HrmpWatermarkMishandling
        /// The candidate didn't follow the rules of HRMP watermark advancement.
        /// </summary>
        HrmpWatermarkMishandling = 24,
        
        /// <summary>
        /// >> InvalidOutboundHrmp
        /// The HRMP messages sent by the candidate is not valid.
        /// </summary>
        InvalidOutboundHrmp = 25,
        
        /// <summary>
        /// >> InvalidValidationCodeHash
        /// The validation code hash of the candidate is not valid.
        /// </summary>
        InvalidValidationCodeHash = 26,
        
        /// <summary>
        /// >> ParaHeadMismatch
        /// The `para_head` hash in the candidate descriptor doesn't match the hash of the actual
        /// para head in the commitments.
        /// </summary>
        ParaHeadMismatch = 27,
        
        /// <summary>
        /// >> BitfieldReferencesFreedCore
        /// A bitfield that references a freed core,
        /// either intentionally or as part of a concluded
        /// invalid dispute.
        /// </summary>
        BitfieldReferencesFreedCore = 28,
    }
    
    /// <summary>
    /// >> 751 - Variant[polkadot_runtime_parachains.inclusion.pallet.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}