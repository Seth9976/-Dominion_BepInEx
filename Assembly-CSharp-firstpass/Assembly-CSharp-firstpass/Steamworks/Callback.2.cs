using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002BA RID: 698
	public sealed class Callback<T> : Callback
	{
		// Token: 0x0600280C RID: 10252 RVA: 0x000ADE28 File Offset: 0x000AC028
		// Note: this type is marked as 'beforefieldinit'.
		static Callback()
		{
			Il2CppClassPointerStore<Callback<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "Callback`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Callback<T>>.NativeClassPtr);
			Callback<T>.NativeFieldInfoPtr_m_Func = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Callback<T>>.NativeClassPtr, "m_Func");
			Callback<T>.NativeFieldInfoPtr_m_bGameServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Callback<T>>.NativeClassPtr, "m_bGameServer");
			Callback<T>.NativeFieldInfoPtr_m_bIsRegistered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Callback<T>>.NativeClassPtr, "m_bIsRegistered");
			Callback<T>.NativeFieldInfoPtr_m_bDisposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Callback<T>>.NativeClassPtr, "m_bDisposed");
			Callback<T>.NativeMethodInfoPtr_add_m_Func_Private_add_Void_DispatchDelegate_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Callback<T>>.NativeClassPtr, 100668414);
			Callback<T>.NativeMethodInfoPtr_remove_m_Func_Private_rem_Void_DispatchDelegate_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Callback<T>>.NativeClassPtr, 100668415);
			Callback<T>.NativeMethodInfoPtr_Create_Public_Static_Callback_1_T_DispatchDelegate_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Callback<T>>.NativeClassPtr, 100668416);
			Callback<T>.NativeMethodInfoPtr_CreateGameServer_Public_Static_Callback_1_T_DispatchDelegate_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Callback<T>>.NativeClassPtr, 100668417);
			Callback<T>.NativeMethodInfoPtr__ctor_Public_Void_DispatchDelegate_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Callback<T>>.NativeClassPtr, 100668418);
			Callback<T>.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Callback<T>>.NativeClassPtr, 100668419);
			Callback<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Callback<T>>.NativeClassPtr, 100668420);
			Callback<T>.NativeMethodInfoPtr_Register_Public_Void_DispatchDelegate_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Callback<T>>.NativeClassPtr, 100668421);
			Callback<T>.NativeMethodInfoPtr_Unregister_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Callback<T>>.NativeClassPtr, 100668422);
			Callback<T>.NativeMethodInfoPtr_get_IsGameServer_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Callback<T>>.NativeClassPtr, 100668423);
			Callback<T>.NativeMethodInfoPtr_GetCallbackType_Internal_Virtual_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Callback<T>>.NativeClassPtr, 100668424);
			Callback<T>.NativeMethodInfoPtr_OnRunCallback_Internal_Virtual_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Callback<T>>.NativeClassPtr, 100668425);
			Callback<T>.NativeMethodInfoPtr_SetUnregistered_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Callback<T>>.NativeClassPtr, 100668426);
		}

		// Token: 0x0600280D RID: 10253 RVA: 0x000ADFE8 File Offset: 0x000AC1E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_m_Func(Callback<T>.DispatchDelegate value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Callback<T>.NativeMethodInfoPtr_add_m_Func_Private_add_Void_DispatchDelegate_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600280E RID: 10254 RVA: 0x000AE02C File Offset: 0x000AC22C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_m_Func(Callback<T>.DispatchDelegate value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Callback<T>.NativeMethodInfoPtr_remove_m_Func_Private_rem_Void_DispatchDelegate_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600280F RID: 10255 RVA: 0x000AE070 File Offset: 0x000AC270
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 207327, RefRangeEnd = 207330, XrefRangeStart = 207321, XrefRangeEnd = 207327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Callback<T> Create(Callback<T>.DispatchDelegate func)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Callback<T>.NativeMethodInfoPtr_Create_Public_Static_Callback_1_T_DispatchDelegate_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Callback<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06002810 RID: 10256 RVA: 0x000AE0B4 File Offset: 0x000AC2B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207330, XrefRangeEnd = 207336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Callback<T> CreateGameServer(Callback<T>.DispatchDelegate func)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Callback<T>.NativeMethodInfoPtr_CreateGameServer_Public_Static_Callback_1_T_DispatchDelegate_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Callback<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06002811 RID: 10257 RVA: 0x000AE0F8 File Offset: 0x000AC2F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207336, XrefRangeEnd = 207362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Callback(Callback<T>.DispatchDelegate func, bool bGameServer = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Callback<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bGameServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Callback<T>.NativeMethodInfoPtr__ctor_Public_Void_DispatchDelegate_T_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002812 RID: 10258 RVA: 0x000AE154 File Offset: 0x000AC354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207362, XrefRangeEnd = 207365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Callback<T>.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002813 RID: 10259 RVA: 0x000AE188 File Offset: 0x000AC388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207365, XrefRangeEnd = 207369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Callback<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002814 RID: 10260 RVA: 0x000AE1BC File Offset: 0x000AC3BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207369, XrefRangeEnd = 207373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Register(Callback<T>.DispatchDelegate func)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(func);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Callback<T>.NativeMethodInfoPtr_Register_Public_Void_DispatchDelegate_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002815 RID: 10261 RVA: 0x000AE200 File Offset: 0x000AC400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207373, XrefRangeEnd = 207377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unregister()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Callback<T>.NativeMethodInfoPtr_Unregister_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x06002816 RID: 10262 RVA: 0x000AE234 File Offset: 0x000AC434
		public unsafe override bool IsGameServer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Callback<T>.NativeMethodInfoPtr_get_IsGameServer_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002817 RID: 10263 RVA: 0x000AE270 File Offset: 0x000AC470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207377, XrefRangeEnd = 207401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type GetCallbackType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Callback<T>.NativeMethodInfoPtr_GetCallbackType_Internal_Virtual_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06002818 RID: 10264 RVA: 0x000AE2B0 File Offset: 0x000AC4B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207401, XrefRangeEnd = 207418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnRunCallback(IntPtr pvParam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pvParam;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Callback<T>.NativeMethodInfoPtr_OnRunCallback_Internal_Virtual_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002819 RID: 10265 RVA: 0x000AE2F0 File Offset: 0x000AC4F0
		[CallerCount(0)]
		public unsafe override void SetUnregistered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Callback<T>.NativeMethodInfoPtr_SetUnregistered_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600281A RID: 10266 RVA: 0x00010378 File Offset: 0x0000E578
		public Callback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x0600281B RID: 10267 RVA: 0x000AE324 File Offset: 0x000AC524
		// (set) Token: 0x0600281C RID: 10268 RVA: 0x00010381 File Offset: 0x0000E581
		public unsafe Callback<T>.DispatchDelegate m_Func
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Callback<T>.NativeFieldInfoPtr_m_Func);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Callback<T>.DispatchDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Callback<T>.NativeFieldInfoPtr_m_Func), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x0600281D RID: 10269 RVA: 0x000AE354 File Offset: 0x000AC554
		// (set) Token: 0x0600281E RID: 10270 RVA: 0x000103A0 File Offset: 0x0000E5A0
		public unsafe bool m_bGameServer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Callback<T>.NativeFieldInfoPtr_m_bGameServer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Callback<T>.NativeFieldInfoPtr_m_bGameServer)) = value;
			}
		}

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x0600281F RID: 10271 RVA: 0x000AE37C File Offset: 0x000AC57C
		// (set) Token: 0x06002820 RID: 10272 RVA: 0x000103BB File Offset: 0x0000E5BB
		public unsafe bool m_bIsRegistered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Callback<T>.NativeFieldInfoPtr_m_bIsRegistered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Callback<T>.NativeFieldInfoPtr_m_bIsRegistered)) = value;
			}
		}

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x06002821 RID: 10273 RVA: 0x000AE3A4 File Offset: 0x000AC5A4
		// (set) Token: 0x06002822 RID: 10274 RVA: 0x000103D6 File Offset: 0x0000E5D6
		public unsafe bool m_bDisposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Callback<T>.NativeFieldInfoPtr_m_bDisposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Callback<T>.NativeFieldInfoPtr_m_bDisposed)) = value;
			}
		}

		// Token: 0x04002717 RID: 10007
		private static readonly IntPtr NativeFieldInfoPtr_m_Func;

		// Token: 0x04002718 RID: 10008
		private static readonly IntPtr NativeFieldInfoPtr_m_bGameServer;

		// Token: 0x04002719 RID: 10009
		private static readonly IntPtr NativeFieldInfoPtr_m_bIsRegistered;

		// Token: 0x0400271A RID: 10010
		private static readonly IntPtr NativeFieldInfoPtr_m_bDisposed;

		// Token: 0x0400271B RID: 10011
		private static readonly IntPtr NativeMethodInfoPtr_add_m_Func_Private_add_Void_DispatchDelegate_T_0;

		// Token: 0x0400271C RID: 10012
		private static readonly IntPtr NativeMethodInfoPtr_remove_m_Func_Private_rem_Void_DispatchDelegate_T_0;

		// Token: 0x0400271D RID: 10013
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Callback_1_T_DispatchDelegate_T_0;

		// Token: 0x0400271E RID: 10014
		private static readonly IntPtr NativeMethodInfoPtr_CreateGameServer_Public_Static_Callback_1_T_DispatchDelegate_T_0;

		// Token: 0x0400271F RID: 10015
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DispatchDelegate_T_Boolean_0;

		// Token: 0x04002720 RID: 10016
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04002721 RID: 10017
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002722 RID: 10018
		private static readonly IntPtr NativeMethodInfoPtr_Register_Public_Void_DispatchDelegate_T_0;

		// Token: 0x04002723 RID: 10019
		private static readonly IntPtr NativeMethodInfoPtr_Unregister_Public_Void_0;

		// Token: 0x04002724 RID: 10020
		private static readonly IntPtr NativeMethodInfoPtr_get_IsGameServer_Public_Virtual_get_Boolean_0;

		// Token: 0x04002725 RID: 10021
		private static readonly IntPtr NativeMethodInfoPtr_GetCallbackType_Internal_Virtual_Type_0;

		// Token: 0x04002726 RID: 10022
		private static readonly IntPtr NativeMethodInfoPtr_OnRunCallback_Internal_Virtual_Void_IntPtr_0;

		// Token: 0x04002727 RID: 10023
		private static readonly IntPtr NativeMethodInfoPtr_SetUnregistered_Internal_Virtual_Void_0;

		// Token: 0x020003A7 RID: 935
		public sealed class DispatchDelegate : MulticastDelegate
		{
			// Token: 0x06003732 RID: 14130 RVA: 0x000E1BD4 File Offset: 0x000DFDD4
			// Note: this type is marked as 'beforefieldinit'.
			static DispatchDelegate()
			{
				Il2CppClassPointerStore<Callback<T>.DispatchDelegate>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Callback<T>>.NativeClassPtr, "DispatchDelegate"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				Callback<T>.DispatchDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Callback<T>.DispatchDelegate>.NativeClassPtr, 100670311);
				Callback<T>.DispatchDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Callback<T>.DispatchDelegate>.NativeClassPtr, 100670312);
				Callback<T>.DispatchDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Callback<T>.DispatchDelegate>.NativeClassPtr, 100670313);
				Callback<T>.DispatchDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Callback<T>.DispatchDelegate>.NativeClassPtr, 100670314);
			}

			// Token: 0x06003733 RID: 14131 RVA: 0x000E1C80 File Offset: 0x000DFE80
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DispatchDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Callback<T>.DispatchDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Callback<T>.DispatchDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003734 RID: 14132 RVA: 0x000E1CDC File Offset: 0x000DFEDC
			[CallerCount(277)]
			[CachedScanResults(RefRangeStart = 94180, RefRangeEnd = 94457, XrefRangeStart = 94180, XrefRangeEnd = 94457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(T param)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = param;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref param;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Callback<T>.DispatchDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}

			// Token: 0x06003735 RID: 14133 RVA: 0x000E1D54 File Offset: 0x000DFF54
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 163501, RefRangeEnd = 163503, XrefRangeStart = 163501, XrefRangeEnd = 163503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(T param, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = param;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref param;
					}
					ptr2 = intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Callback<T>.DispatchDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr4) : null;
			}

			// Token: 0x06003736 RID: 14134 RVA: 0x000E1E00 File Offset: 0x000E0000
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 43385, RefRangeEnd = 43388, XrefRangeStart = 43385, XrefRangeEnd = 43388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Callback<T>.DispatchDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003737 RID: 14135 RVA: 0x000155FF File Offset: 0x000137FF
			public DispatchDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003738 RID: 14136 RVA: 0x00015608 File Offset: 0x00013808
			public static implicit operator Callback<T>.DispatchDelegate(Action<T> A_0)
			{
				return DelegateSupport.ConvertDelegate<Callback<T>.DispatchDelegate>(A_0);
			}

			// Token: 0x06003739 RID: 14137 RVA: 0x00015610 File Offset: 0x00013810
			public static Callback<T>.DispatchDelegate operator +(Callback<T>.DispatchDelegate A_0, Callback<T>.DispatchDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Callback<T>.DispatchDelegate>();
			}

			// Token: 0x0600373A RID: 14138 RVA: 0x0001561E File Offset: 0x0001381E
			public static Callback<T>.DispatchDelegate operator -(Callback<T>.DispatchDelegate A_0, Callback<T>.DispatchDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<Callback<T>.DispatchDelegate>();
				}
				return delegate2;
			}

			// Token: 0x04003242 RID: 12866
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04003243 RID: 12867
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T_0;

			// Token: 0x04003244 RID: 12868
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T_AsyncCallback_Object_0;

			// Token: 0x04003245 RID: 12869
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
