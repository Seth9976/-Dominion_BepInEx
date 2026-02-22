using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000082 RID: 130
	public class Gradient : Object
	{
		// Token: 0x06000CAF RID: 3247 RVA: 0x0003625C File Offset: 0x0003445C
		// Note: this type is marked as 'beforefieldinit'.
		static Gradient()
		{
			Il2CppClassPointerStore<Gradient>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Gradient");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Gradient>.NativeClassPtr);
			Gradient.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gradient>.NativeClassPtr, "m_Ptr");
			Gradient.NativeMethodInfoPtr_Init_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100664006);
			Gradient.NativeMethodInfoPtr_Cleanup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100664007);
			Gradient.NativeMethodInfoPtr_Internal_Equals_Private_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100664008);
			Gradient.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100664009);
			Gradient.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100664010);
			Gradient.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100664011);
			Gradient.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Gradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100664012);
			Gradient.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100664013);
			Gradient.get_modeDelegateField = IL2CPP.ResolveICall<Gradient.get_modeDelegate>("UnityEngine.Gradient::get_mode");
			Gradient.set_modeDelegateField = IL2CPP.ResolveICall<Gradient.set_modeDelegate>("UnityEngine.Gradient::set_mode");
			Gradient.Evaluate_InjectedDelegateField = IL2CPP.ResolveICall<Gradient.Evaluate_InjectedDelegate>("UnityEngine.Gradient::Evaluate_Injected");
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x00036370 File Offset: 0x00034570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65281, XrefRangeEnd = 65283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Init()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_Init_Private_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x000363A0 File Offset: 0x000345A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65283, XrefRangeEnd = 65285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_Cleanup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x000363D4 File Offset: 0x000345D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65285, XrefRangeEnd = 65287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Internal_Equals(IntPtr other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_Internal_Equals_Private_Boolean_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x00036420 File Offset: 0x00034620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65287, XrefRangeEnd = 65290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Gradient()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Gradient>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x0003645C File Offset: 0x0003465C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65290, XrefRangeEnd = 65295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Gradient.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CB5 RID: 3253 RVA: 0x00036498 File Offset: 0x00034698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65295, XrefRangeEnd = 65305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Gradient.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CB6 RID: 3254 RVA: 0x000364F0 File Offset: 0x000346F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65305, XrefRangeEnd = 65311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Equals(Gradient other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Gradient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CB7 RID: 3255 RVA: 0x00036540 File Offset: 0x00034740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Gradient.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CB8 RID: 3256 RVA: 0x000090F9 File Offset: 0x000072F9
		public Gradient(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000CB9 RID: 3257 RVA: 0x00036588 File Offset: 0x00034788
		// (set) Token: 0x06000CBA RID: 3258 RVA: 0x00009102 File Offset: 0x00007302
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gradient.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gradient.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x000365B0 File Offset: 0x000347B0
		public Color Evaluate(float time)
		{
			Color color;
			this.Evaluate_Injected(time, out color);
			return color;
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000CBC RID: 3260 RVA: 0x0000911D File Offset: 0x0000731D
		// (set) Token: 0x06000CBD RID: 3261 RVA: 0x0000912F File Offset: 0x0000732F
		public GradientMode mode
		{
			get
			{
				return Gradient.get_modeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Gradient.set_modeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000CBE RID: 3262 RVA: 0x00009142 File Offset: 0x00007342
		public void Evaluate_Injected(float time, out Color ret)
		{
			Gradient.Evaluate_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), time, out ret);
		}

		// Token: 0x04000A28 RID: 2600
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04000A29 RID: 2601
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Static_IntPtr_0;

		// Token: 0x04000A2A RID: 2602
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Private_Void_0;

		// Token: 0x04000A2B RID: 2603
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Equals_Private_Boolean_IntPtr_0;

		// Token: 0x04000A2C RID: 2604
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000A2D RID: 2605
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000A2E RID: 2606
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000A2F RID: 2607
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Gradient_0;

		// Token: 0x04000A30 RID: 2608
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000A31 RID: 2609
		private static readonly Gradient.get_modeDelegate get_modeDelegateField;

		// Token: 0x04000A32 RID: 2610
		private static readonly Gradient.set_modeDelegate set_modeDelegateField;

		// Token: 0x04000A33 RID: 2611
		private static readonly Gradient.Evaluate_InjectedDelegate Evaluate_InjectedDelegateField;

		// Token: 0x0200073B RID: 1851
		// (Invoke) Token: 0x06002C39 RID: 11321
		private delegate GradientMode get_modeDelegate(IntPtr @this);

		// Token: 0x0200073C RID: 1852
		// (Invoke) Token: 0x06002C3B RID: 11323
		private delegate void set_modeDelegate(IntPtr @this, GradientMode value);

		// Token: 0x0200073D RID: 1853
		// (Invoke) Token: 0x06002C3D RID: 11325
		private delegate void Evaluate_InjectedDelegate(IntPtr @this, float time, [Out] IntPtr ret);
	}
}
