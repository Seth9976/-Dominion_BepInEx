using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.CompilerServices;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000276 RID: 630
	public class OSSpecificSynchronizationContext : SynchronizationContext
	{
		// Token: 0x06002B2C RID: 11052 RVA: 0x000DE078 File Offset: 0x000DC278
		// Note: this type is marked as 'beforefieldinit'.
		static OSSpecificSynchronizationContext()
		{
			Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "OSSpecificSynchronizationContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr);
			OSSpecificSynchronizationContext.NativeFieldInfoPtr_m_OSSynchronizationContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr, "m_OSSynchronizationContext");
			OSSpecificSynchronizationContext.NativeFieldInfoPtr_s_ContextCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr, "s_ContextCache");
			OSSpecificSynchronizationContext.NativeMethodInfoPtr__ctor_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr, 100670163);
			OSSpecificSynchronizationContext.NativeMethodInfoPtr_Get_Public_Static_OSSpecificSynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr, 100670164);
			OSSpecificSynchronizationContext.NativeMethodInfoPtr_CreateCopy_Public_Virtual_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr, 100670165);
			OSSpecificSynchronizationContext.NativeMethodInfoPtr_Send_Public_Virtual_Void_SendOrPostCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr, 100670166);
			OSSpecificSynchronizationContext.NativeMethodInfoPtr_Post_Public_Virtual_Void_SendOrPostCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr, 100670167);
			OSSpecificSynchronizationContext.NativeMethodInfoPtr_InvocationEntry_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr, 100670168);
			OSSpecificSynchronizationContext.NativeMethodInfoPtr_GetOSContext_Private_Static_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr, 100670169);
			OSSpecificSynchronizationContext.NativeMethodInfoPtr_PostInternal_Private_Static_Void_Object_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr, 100670170);
		}

		// Token: 0x06002B2D RID: 11053 RVA: 0x000DE170 File Offset: 0x000DC370
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 14927, RefRangeEnd = 14932, XrefRangeStart = 14927, XrefRangeEnd = 14932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OSSpecificSynchronizationContext(Object osContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(osContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OSSpecificSynchronizationContext.NativeMethodInfoPtr__ctor_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B2E RID: 11054 RVA: 0x000DE1BC File Offset: 0x000DC3BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 332401, RefRangeEnd = 332404, XrefRangeStart = 332376, XrefRangeEnd = 332401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static OSSpecificSynchronizationContext Get()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OSSpecificSynchronizationContext.NativeMethodInfoPtr_Get_Public_Static_OSSpecificSynchronizationContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<OSSpecificSynchronizationContext>(intPtr3) : null;
		}

		// Token: 0x06002B2F RID: 11055 RVA: 0x000DE1F0 File Offset: 0x000DC3F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332404, XrefRangeEnd = 332408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SynchronizationContext CreateCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OSSpecificSynchronizationContext.NativeMethodInfoPtr_CreateCopy_Public_Virtual_SynchronizationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr3) : null;
		}

		// Token: 0x06002B30 RID: 11056 RVA: 0x000DE23C File Offset: 0x000DC43C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332408, XrefRangeEnd = 332421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Send(SendOrPostCallback d, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OSSpecificSynchronizationContext.NativeMethodInfoPtr_Send_Public_Virtual_Void_SendOrPostCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B31 RID: 11057 RVA: 0x000DE29C File Offset: 0x000DC49C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332421, XrefRangeEnd = 332443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Post(SendOrPostCallback d, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OSSpecificSynchronizationContext.NativeMethodInfoPtr_Post_Public_Virtual_Void_SendOrPostCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B32 RID: 11058 RVA: 0x000DE2FC File Offset: 0x000DC4FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332443, XrefRangeEnd = 332455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvocationEntry(IntPtr arg)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref arg;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OSSpecificSynchronizationContext.NativeMethodInfoPtr_InvocationEntry_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B33 RID: 11059 RVA: 0x000DE330 File Offset: 0x000DC530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332455, XrefRangeEnd = 332456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GetOSContext()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OSSpecificSynchronizationContext.NativeMethodInfoPtr_GetOSContext_Private_Static_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002B34 RID: 11060 RVA: 0x000DE364 File Offset: 0x000DC564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332456, XrefRangeEnd = 332457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PostInternal(Object osSynchronizationContext, IntPtr callback, IntPtr arg)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(osSynchronizationContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callback;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OSSpecificSynchronizationContext.NativeMethodInfoPtr_PostInternal_Private_Static_Void_Object_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B35 RID: 11061 RVA: 0x0000F0A1 File Offset: 0x0000D2A1
		public OSSpecificSynchronizationContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x06002B36 RID: 11062 RVA: 0x000DE3B8 File Offset: 0x000DC5B8
		// (set) Token: 0x06002B37 RID: 11063 RVA: 0x0000F0AA File Offset: 0x0000D2AA
		public unsafe Object m_OSSynchronizationContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OSSpecificSynchronizationContext.NativeFieldInfoPtr_m_OSSynchronizationContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OSSpecificSynchronizationContext.NativeFieldInfoPtr_m_OSSynchronizationContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x06002B38 RID: 11064 RVA: 0x000DE3E8 File Offset: 0x000DC5E8
		// (set) Token: 0x06002B39 RID: 11065 RVA: 0x0000F0C9 File Offset: 0x0000D2C9
		public unsafe static ConditionalWeakTable<Object, OSSpecificSynchronizationContext> s_ContextCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(OSSpecificSynchronizationContext.NativeFieldInfoPtr_s_ContextCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConditionalWeakTable<Object, OSSpecificSynchronizationContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OSSpecificSynchronizationContext.NativeFieldInfoPtr_s_ContextCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040025B3 RID: 9651
		private static readonly IntPtr NativeFieldInfoPtr_m_OSSynchronizationContext;

		// Token: 0x040025B4 RID: 9652
		private static readonly IntPtr NativeFieldInfoPtr_s_ContextCache;

		// Token: 0x040025B5 RID: 9653
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Object_0;

		// Token: 0x040025B6 RID: 9654
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_OSSpecificSynchronizationContext_0;

		// Token: 0x040025B7 RID: 9655
		private static readonly IntPtr NativeMethodInfoPtr_CreateCopy_Public_Virtual_SynchronizationContext_0;

		// Token: 0x040025B8 RID: 9656
		private static readonly IntPtr NativeMethodInfoPtr_Send_Public_Virtual_Void_SendOrPostCallback_Object_0;

		// Token: 0x040025B9 RID: 9657
		private static readonly IntPtr NativeMethodInfoPtr_Post_Public_Virtual_Void_SendOrPostCallback_Object_0;

		// Token: 0x040025BA RID: 9658
		private static readonly IntPtr NativeMethodInfoPtr_InvocationEntry_Private_Static_Void_IntPtr_0;

		// Token: 0x040025BB RID: 9659
		private static readonly IntPtr NativeMethodInfoPtr_GetOSContext_Private_Static_Object_0;

		// Token: 0x040025BC RID: 9660
		private static readonly IntPtr NativeMethodInfoPtr_PostInternal_Private_Static_Void_Object_IntPtr_IntPtr_0;

		// Token: 0x020005ED RID: 1517
		public sealed class InvocationEntryDelegate : MulticastDelegate
		{
			// Token: 0x06005266 RID: 21094 RVA: 0x0001F77A File Offset: 0x0001D97A
			// Note: this type is marked as 'beforefieldinit'.
			static InvocationEntryDelegate()
			{
				Il2CppClassPointerStore<OSSpecificSynchronizationContext.InvocationEntryDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr, "InvocationEntryDelegate");
				OSSpecificSynchronizationContext.InvocationEntryDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSSpecificSynchronizationContext.InvocationEntryDelegate>.NativeClassPtr, 100670172);
				OSSpecificSynchronizationContext.InvocationEntryDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSSpecificSynchronizationContext.InvocationEntryDelegate>.NativeClassPtr, 100670173);
			}

			// Token: 0x06005267 RID: 21095 RVA: 0x0016F774 File Offset: 0x0016D974
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InvocationEntryDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OSSpecificSynchronizationContext.InvocationEntryDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OSSpecificSynchronizationContext.InvocationEntryDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005268 RID: 21096 RVA: 0x0016F7D0 File Offset: 0x0016D9D0
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 209501, RefRangeEnd = 209504, XrefRangeStart = 209501, XrefRangeEnd = 209504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(IntPtr arg)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref arg;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OSSpecificSynchronizationContext.InvocationEntryDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005269 RID: 21097 RVA: 0x0001F7B8 File Offset: 0x0001D9B8
			public InvocationEntryDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600526A RID: 21098 RVA: 0x0001F7C1 File Offset: 0x0001D9C1
			public static implicit operator OSSpecificSynchronizationContext.InvocationEntryDelegate(Action<IntPtr> A_0)
			{
				return DelegateSupport.ConvertDelegate<OSSpecificSynchronizationContext.InvocationEntryDelegate>(A_0);
			}

			// Token: 0x0600526B RID: 21099 RVA: 0x0001F7C9 File Offset: 0x0001D9C9
			public static OSSpecificSynchronizationContext.InvocationEntryDelegate operator +(OSSpecificSynchronizationContext.InvocationEntryDelegate A_0, OSSpecificSynchronizationContext.InvocationEntryDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<OSSpecificSynchronizationContext.InvocationEntryDelegate>();
			}

			// Token: 0x0600526C RID: 21100 RVA: 0x0001F7D7 File Offset: 0x0001D9D7
			public static OSSpecificSynchronizationContext.InvocationEntryDelegate operator -(OSSpecificSynchronizationContext.InvocationEntryDelegate A_0, OSSpecificSynchronizationContext.InvocationEntryDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<OSSpecificSynchronizationContext.InvocationEntryDelegate>();
				}
				return delegate2;
			}

			// Token: 0x040042D2 RID: 17106
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040042D3 RID: 17107
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0;
		}

		// Token: 0x020005EE RID: 1518
		public sealed class MonoPInvokeCallbackAttribute : Attribute
		{
			// Token: 0x0600526D RID: 21101 RVA: 0x0001F7E8 File Offset: 0x0001D9E8
			// Note: this type is marked as 'beforefieldinit'.
			static MonoPInvokeCallbackAttribute()
			{
				Il2CppClassPointerStore<OSSpecificSynchronizationContext.MonoPInvokeCallbackAttribute>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr, "MonoPInvokeCallbackAttribute");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OSSpecificSynchronizationContext.MonoPInvokeCallbackAttribute>.NativeClassPtr);
				OSSpecificSynchronizationContext.MonoPInvokeCallbackAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSSpecificSynchronizationContext.MonoPInvokeCallbackAttribute>.NativeClassPtr, 100670174);
			}

			// Token: 0x0600526E RID: 21102 RVA: 0x0016F810 File Offset: 0x0016DA10
			[CallerCount(114)]
			[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MonoPInvokeCallbackAttribute(Type t)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OSSpecificSynchronizationContext.MonoPInvokeCallbackAttribute>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OSSpecificSynchronizationContext.MonoPInvokeCallbackAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600526F RID: 21103 RVA: 0x0001F81C File Offset: 0x0001DA1C
			public MonoPInvokeCallbackAttribute(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040042D4 RID: 17108
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;
		}

		// Token: 0x020005EF RID: 1519
		public class InvocationContext : Object
		{
			// Token: 0x06005270 RID: 21104 RVA: 0x0016F85C File Offset: 0x0016DA5C
			// Note: this type is marked as 'beforefieldinit'.
			static InvocationContext()
			{
				Il2CppClassPointerStore<OSSpecificSynchronizationContext.InvocationContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr, "InvocationContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OSSpecificSynchronizationContext.InvocationContext>.NativeClassPtr);
				OSSpecificSynchronizationContext.InvocationContext.NativeFieldInfoPtr_m_Delegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OSSpecificSynchronizationContext.InvocationContext>.NativeClassPtr, "m_Delegate");
				OSSpecificSynchronizationContext.InvocationContext.NativeFieldInfoPtr_m_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OSSpecificSynchronizationContext.InvocationContext>.NativeClassPtr, "m_State");
				OSSpecificSynchronizationContext.InvocationContext.NativeMethodInfoPtr__ctor_Public_Void_SendOrPostCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSSpecificSynchronizationContext.InvocationContext>.NativeClassPtr, 100670175);
				OSSpecificSynchronizationContext.InvocationContext.NativeMethodInfoPtr_Invoke_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSSpecificSynchronizationContext.InvocationContext>.NativeClassPtr, 100670176);
			}

			// Token: 0x06005271 RID: 21105 RVA: 0x0016F8D8 File Offset: 0x0016DAD8
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 5356, RefRangeEnd = 5400, XrefRangeStart = 5356, XrefRangeEnd = 5400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InvocationContext(SendOrPostCallback d, Object state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OSSpecificSynchronizationContext.InvocationContext>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OSSpecificSynchronizationContext.InvocationContext.NativeMethodInfoPtr__ctor_Public_Void_SendOrPostCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005272 RID: 21106 RVA: 0x0016F938 File Offset: 0x0016DB38
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 332371, RefRangeEnd = 332372, XrefRangeStart = 332369, XrefRangeEnd = 332371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OSSpecificSynchronizationContext.InvocationContext.NativeMethodInfoPtr_Invoke_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005273 RID: 21107 RVA: 0x0001F825 File Offset: 0x0001DA25
			public InvocationContext(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700150F RID: 5391
			// (get) Token: 0x06005274 RID: 21108 RVA: 0x0016F96C File Offset: 0x0016DB6C
			// (set) Token: 0x06005275 RID: 21109 RVA: 0x0001F82E File Offset: 0x0001DA2E
			public unsafe SendOrPostCallback m_Delegate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OSSpecificSynchronizationContext.InvocationContext.NativeFieldInfoPtr_m_Delegate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SendOrPostCallback>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OSSpecificSynchronizationContext.InvocationContext.NativeFieldInfoPtr_m_Delegate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001510 RID: 5392
			// (get) Token: 0x06005276 RID: 21110 RVA: 0x0016F99C File Offset: 0x0016DB9C
			// (set) Token: 0x06005277 RID: 21111 RVA: 0x0001F84D File Offset: 0x0001DA4D
			public unsafe Object m_State
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OSSpecificSynchronizationContext.InvocationContext.NativeFieldInfoPtr_m_State);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OSSpecificSynchronizationContext.InvocationContext.NativeFieldInfoPtr_m_State), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040042D5 RID: 17109
			private static readonly IntPtr NativeFieldInfoPtr_m_Delegate;

			// Token: 0x040042D6 RID: 17110
			private static readonly IntPtr NativeFieldInfoPtr_m_State;

			// Token: 0x040042D7 RID: 17111
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SendOrPostCallback_Object_0;

			// Token: 0x040042D8 RID: 17112
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_0;
		}

		// Token: 0x020005F0 RID: 1520
		[ObfuscatedName("System.Threading.OSSpecificSynchronizationContext+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06005278 RID: 21112 RVA: 0x0016F9CC File Offset: 0x0016DBCC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<OSSpecificSynchronizationContext.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OSSpecificSynchronizationContext>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OSSpecificSynchronizationContext.__c>.NativeClassPtr);
				OSSpecificSynchronizationContext.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OSSpecificSynchronizationContext.__c>.NativeClassPtr, "<>9");
				OSSpecificSynchronizationContext.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OSSpecificSynchronizationContext.__c>.NativeClassPtr, "<>9__3_0");
				OSSpecificSynchronizationContext.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSSpecificSynchronizationContext.__c>.NativeClassPtr, 100670178);
				OSSpecificSynchronizationContext.__c.NativeMethodInfoPtr__Get_b__3_0_Internal_OSSpecificSynchronizationContext_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OSSpecificSynchronizationContext.__c>.NativeClassPtr, 100670179);
			}

			// Token: 0x06005279 RID: 21113 RVA: 0x0016FA48 File Offset: 0x0016DC48
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OSSpecificSynchronizationContext.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OSSpecificSynchronizationContext.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600527A RID: 21114 RVA: 0x0016FA84 File Offset: 0x0016DC84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332372, XrefRangeEnd = 332376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OSSpecificSynchronizationContext _Get_b__3_0(Object _osContext)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_osContext);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OSSpecificSynchronizationContext.__c.NativeMethodInfoPtr__Get_b__3_0_Internal_OSSpecificSynchronizationContext_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<OSSpecificSynchronizationContext>(intPtr3) : null;
				}
			}

			// Token: 0x0600527B RID: 21115 RVA: 0x0001F86C File Offset: 0x0001DA6C
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001511 RID: 5393
			// (get) Token: 0x0600527C RID: 21116 RVA: 0x0016FAD4 File Offset: 0x0016DCD4
			// (set) Token: 0x0600527D RID: 21117 RVA: 0x0001F875 File Offset: 0x0001DA75
			public unsafe static OSSpecificSynchronizationContext.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(OSSpecificSynchronizationContext.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OSSpecificSynchronizationContext.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(OSSpecificSynchronizationContext.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001512 RID: 5394
			// (get) Token: 0x0600527E RID: 21118 RVA: 0x0016FAFC File Offset: 0x0016DCFC
			// (set) Token: 0x0600527F RID: 21119 RVA: 0x0001F887 File Offset: 0x0001DA87
			public unsafe static ConditionalWeakTable<Object, OSSpecificSynchronizationContext>.CreateValueCallback __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(OSSpecificSynchronizationContext.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConditionalWeakTable<Object, OSSpecificSynchronizationContext>.CreateValueCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(OSSpecificSynchronizationContext.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040042D9 RID: 17113
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040042DA RID: 17114
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x040042DB RID: 17115
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040042DC RID: 17116
			private static readonly IntPtr NativeMethodInfoPtr__Get_b__3_0_Internal_OSSpecificSynchronizationContext_Object_0;
		}
	}
}
