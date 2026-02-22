using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using SA.Common.Pattern;

namespace SA.Fitness
{
	// Token: 0x0200032C RID: 812
	public sealed class Sessions : Singleton<Sessions>
	{
		// Token: 0x06002FD6 RID: 12246 RVA: 0x000CC17C File Offset: 0x000CA37C
		// Note: this type is marked as 'beforefieldinit'.
		static Sessions()
		{
			Il2CppClassPointerStore<Sessions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Fitness", "Sessions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sessions>.NativeClassPtr);
			Sessions.NativeFieldInfoPtr_startSessionRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sessions>.NativeClassPtr, "startSessionRequests");
			Sessions.NativeFieldInfoPtr_stopSessionRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sessions>.NativeClassPtr, "stopSessionRequests");
			Sessions.NativeFieldInfoPtr_readSessionRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sessions>.NativeClassPtr, "readSessionRequests");
			Sessions.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sessions>.NativeClassPtr, 100669632);
			Sessions.NativeMethodInfoPtr_StartSession_Public_Void_StartSessionRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sessions>.NativeClassPtr, 100669633);
			Sessions.NativeMethodInfoPtr_StopSession_Public_Void_StopSessionRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sessions>.NativeClassPtr, 100669634);
			Sessions.NativeMethodInfoPtr_InsertSession_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sessions>.NativeClassPtr, 100669635);
			Sessions.NativeMethodInfoPtr_ReadSession_Public_Void_ReadSessionRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sessions>.NativeClassPtr, 100669636);
			Sessions.NativeMethodInfoPtr_SessionStartCallbackHandler_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sessions>.NativeClassPtr, 100669637);
			Sessions.NativeMethodInfoPtr_SessionStopCallbackHandler_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sessions>.NativeClassPtr, 100669638);
			Sessions.NativeMethodInfoPtr_SessionReadCallbackHandler_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sessions>.NativeClassPtr, 100669639);
			Sessions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sessions>.NativeClassPtr, 100669640);
		}

		// Token: 0x06002FD7 RID: 12247 RVA: 0x000CC29C File Offset: 0x000CA49C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221206, XrefRangeEnd = 221211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sessions.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FD8 RID: 12248 RVA: 0x000CC2D0 File Offset: 0x000CA4D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221243, RefRangeEnd = 221244, XrefRangeStart = 221211, XrefRangeEnd = 221243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartSession(StartSessionRequest request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sessions.NativeMethodInfoPtr_StartSession_Public_Void_StartSessionRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002FD9 RID: 12249 RVA: 0x000CC314 File Offset: 0x000CA514
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221258, RefRangeEnd = 221259, XrefRangeStart = 221244, XrefRangeEnd = 221258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopSession(StopSessionRequest request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sessions.NativeMethodInfoPtr_StopSession_Public_Void_StopSessionRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002FDA RID: 12250 RVA: 0x000CC358 File Offset: 0x000CA558
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertSession()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sessions.NativeMethodInfoPtr_InsertSession_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FDB RID: 12251 RVA: 0x000CC38C File Offset: 0x000CA58C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221288, RefRangeEnd = 221289, XrefRangeStart = 221259, XrefRangeEnd = 221288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadSession(ReadSessionRequest request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sessions.NativeMethodInfoPtr_ReadSession_Public_Void_ReadSessionRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002FDC RID: 12252 RVA: 0x000CC3D0 File Offset: 0x000CA5D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221289, XrefRangeEnd = 221331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SessionStartCallbackHandler(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sessions.NativeMethodInfoPtr_SessionStartCallbackHandler_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002FDD RID: 12253 RVA: 0x000CC414 File Offset: 0x000CA614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221331, XrefRangeEnd = 221354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SessionStopCallbackHandler(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sessions.NativeMethodInfoPtr_SessionStopCallbackHandler_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002FDE RID: 12254 RVA: 0x000CC458 File Offset: 0x000CA658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221354, XrefRangeEnd = 221377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SessionReadCallbackHandler(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sessions.NativeMethodInfoPtr_SessionReadCallbackHandler_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002FDF RID: 12255 RVA: 0x000CC49C File Offset: 0x000CA69C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221377, XrefRangeEnd = 221401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sessions()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sessions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sessions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FE0 RID: 12256 RVA: 0x0001240D File Offset: 0x0001060D
		public Sessions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x06002FE1 RID: 12257 RVA: 0x000CC4D8 File Offset: 0x000CA6D8
		// (set) Token: 0x06002FE2 RID: 12258 RVA: 0x00012416 File Offset: 0x00010616
		public unsafe Dictionary<int, StartSessionRequest> startSessionRequests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sessions.NativeFieldInfoPtr_startSessionRequests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, StartSessionRequest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sessions.NativeFieldInfoPtr_startSessionRequests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x06002FE3 RID: 12259 RVA: 0x000CC508 File Offset: 0x000CA708
		// (set) Token: 0x06002FE4 RID: 12260 RVA: 0x00012435 File Offset: 0x00010635
		public unsafe Dictionary<int, StopSessionRequest> stopSessionRequests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sessions.NativeFieldInfoPtr_stopSessionRequests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, StopSessionRequest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sessions.NativeFieldInfoPtr_stopSessionRequests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x06002FE5 RID: 12261 RVA: 0x000CC538 File Offset: 0x000CA738
		// (set) Token: 0x06002FE6 RID: 12262 RVA: 0x00012454 File Offset: 0x00010654
		public unsafe Dictionary<int, ReadSessionRequest> readSessionRequests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sessions.NativeFieldInfoPtr_readSessionRequests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ReadSessionRequest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sessions.NativeFieldInfoPtr_readSessionRequests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002DA7 RID: 11687
		private static readonly IntPtr NativeFieldInfoPtr_startSessionRequests;

		// Token: 0x04002DA8 RID: 11688
		private static readonly IntPtr NativeFieldInfoPtr_stopSessionRequests;

		// Token: 0x04002DA9 RID: 11689
		private static readonly IntPtr NativeFieldInfoPtr_readSessionRequests;

		// Token: 0x04002DAA RID: 11690
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04002DAB RID: 11691
		private static readonly IntPtr NativeMethodInfoPtr_StartSession_Public_Void_StartSessionRequest_0;

		// Token: 0x04002DAC RID: 11692
		private static readonly IntPtr NativeMethodInfoPtr_StopSession_Public_Void_StopSessionRequest_0;

		// Token: 0x04002DAD RID: 11693
		private static readonly IntPtr NativeMethodInfoPtr_InsertSession_Public_Void_0;

		// Token: 0x04002DAE RID: 11694
		private static readonly IntPtr NativeMethodInfoPtr_ReadSession_Public_Void_ReadSessionRequest_0;

		// Token: 0x04002DAF RID: 11695
		private static readonly IntPtr NativeMethodInfoPtr_SessionStartCallbackHandler_Private_Void_String_0;

		// Token: 0x04002DB0 RID: 11696
		private static readonly IntPtr NativeMethodInfoPtr_SessionStopCallbackHandler_Private_Void_String_0;

		// Token: 0x04002DB1 RID: 11697
		private static readonly IntPtr NativeMethodInfoPtr_SessionReadCallbackHandler_Private_Void_String_0;

		// Token: 0x04002DB2 RID: 11698
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
