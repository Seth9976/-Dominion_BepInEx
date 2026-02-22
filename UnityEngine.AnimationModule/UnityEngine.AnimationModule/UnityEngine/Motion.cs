using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000011 RID: 17
	public class Motion : Object
	{
		// Token: 0x060001EF RID: 495 RVA: 0x000090D0 File Offset: 0x000072D0
		// Note: this type is marked as 'beforefieldinit'.
		static Motion()
		{
			Il2CppClassPointerStore<Motion>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "Motion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Motion>.NativeClassPtr);
			Motion.get_averageDurationDelegateField = IL2CPP.ResolveICall<Motion.get_averageDurationDelegate>("UnityEngine.Motion::get_averageDuration");
			Motion.get_averageAngularSpeedDelegateField = IL2CPP.ResolveICall<Motion.get_averageAngularSpeedDelegate>("UnityEngine.Motion::get_averageAngularSpeed");
			Motion.get_apparentSpeedDelegateField = IL2CPP.ResolveICall<Motion.get_apparentSpeedDelegate>("UnityEngine.Motion::get_apparentSpeed");
			Motion.get_isLoopingDelegateField = IL2CPP.ResolveICall<Motion.get_isLoopingDelegate>("UnityEngine.Motion::get_isLooping");
			Motion.get_legacyDelegateField = IL2CPP.ResolveICall<Motion.get_legacyDelegate>("UnityEngine.Motion::get_legacy");
			Motion.get_isHumanMotionDelegateField = IL2CPP.ResolveICall<Motion.get_isHumanMotionDelegate>("UnityEngine.Motion::get_isHumanMotion");
			Motion.get_averageSpeed_InjectedDelegateField = IL2CPP.ResolveICall<Motion.get_averageSpeed_InjectedDelegate>("UnityEngine.Motion::get_averageSpeed_Injected");
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0000346F File Offset: 0x0000166F
		public Motion(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x00003478 File Offset: 0x00001678
		public float averageDuration
		{
			get
			{
				return Motion.get_averageDurationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x0000348A File Offset: 0x0000168A
		public float averageAngularSpeed
		{
			get
			{
				return Motion.get_averageAngularSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x0000916C File Offset: 0x0000736C
		public Vector3 averageSpeed
		{
			get
			{
				Vector3 vector;
				this.get_averageSpeed_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x0000349C File Offset: 0x0000169C
		public float apparentSpeed
		{
			get
			{
				return Motion.get_apparentSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x000034AE File Offset: 0x000016AE
		public bool isLooping
		{
			get
			{
				return Motion.get_isLoopingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x000034C0 File Offset: 0x000016C0
		public bool legacy
		{
			get
			{
				return Motion.get_legacyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x000034D2 File Offset: 0x000016D2
		public bool isHumanMotion
		{
			get
			{
				return Motion.get_isHumanMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00009184 File Offset: 0x00007384
		public bool ValidateIfRetargetable(bool val)
		{
			return false;
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x000034E4 File Offset: 0x000016E4
		public bool isAnimatorMotion
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060001FA RID: 506 RVA: 0x000034F1 File Offset: 0x000016F1
		public void get_averageSpeed_Injected(out Vector3 ret)
		{
			Motion.get_averageSpeed_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x04000135 RID: 309
		private static readonly Motion.get_averageDurationDelegate get_averageDurationDelegateField;

		// Token: 0x04000136 RID: 310
		private static readonly Motion.get_averageAngularSpeedDelegate get_averageAngularSpeedDelegateField;

		// Token: 0x04000137 RID: 311
		private static readonly Motion.get_apparentSpeedDelegate get_apparentSpeedDelegateField;

		// Token: 0x04000138 RID: 312
		private static readonly Motion.get_isLoopingDelegate get_isLoopingDelegateField;

		// Token: 0x04000139 RID: 313
		private static readonly Motion.get_legacyDelegate get_legacyDelegateField;

		// Token: 0x0400013A RID: 314
		private static readonly Motion.get_isHumanMotionDelegate get_isHumanMotionDelegateField;

		// Token: 0x0400013B RID: 315
		private static readonly Motion.get_averageSpeed_InjectedDelegate get_averageSpeed_InjectedDelegateField;

		// Token: 0x02000121 RID: 289
		// (Invoke) Token: 0x060006E8 RID: 1768
		private delegate float get_averageDurationDelegate(IntPtr @this);

		// Token: 0x02000122 RID: 290
		// (Invoke) Token: 0x060006EA RID: 1770
		private delegate float get_averageAngularSpeedDelegate(IntPtr @this);

		// Token: 0x02000123 RID: 291
		// (Invoke) Token: 0x060006EC RID: 1772
		private delegate float get_apparentSpeedDelegate(IntPtr @this);

		// Token: 0x02000124 RID: 292
		// (Invoke) Token: 0x060006EE RID: 1774
		private delegate bool get_isLoopingDelegate(IntPtr @this);

		// Token: 0x02000125 RID: 293
		// (Invoke) Token: 0x060006F0 RID: 1776
		private delegate bool get_legacyDelegate(IntPtr @this);

		// Token: 0x02000126 RID: 294
		// (Invoke) Token: 0x060006F2 RID: 1778
		private delegate bool get_isHumanMotionDelegate(IntPtr @this);

		// Token: 0x02000127 RID: 295
		// (Invoke) Token: 0x060006F4 RID: 1780
		private delegate void get_averageSpeed_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);
	}
}
